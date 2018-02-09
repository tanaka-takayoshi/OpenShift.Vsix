using Microsoft.Rest;
using Microsoft.VisualStudio.Settings;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Settings;
using Newtonsoft.Json;
using OpenShift.DotNet.Service;
using Reactive.Bindings;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Task = System.Threading.Tasks.Task;

namespace OpenShiftForVisualStudio.Vsix.Models
{

    internal class OpenShiftMastersModel
    {
        internal static OpenShiftMastersModel Instance = new OpenShiftMastersModel();

        const string CollectionPath = "MasterEndpoints";
        const string PropertyName = "AllMasterEndpoints";

        internal ReactiveCollection<OpenShiftMasterModel> Masters { get; } = new ReactiveCollection<OpenShiftMasterModel>();
        readonly WritableSettingsStore writableSettingsStore;

        private OpenShiftMastersModel()
        {
            var shellSettingsManager = new ShellSettingsManager(ServiceProvider.GlobalProvider);
            writableSettingsStore = shellSettingsManager.GetWritableSettingsStore(SettingsScope.UserSettings);

            Load();
        }

        internal void AddItem(OpenShiftMasterModel model)
        {
            Masters.Add(model);
        }

        internal void DeleteItem(OpenShiftMasterModel masterModel)
        {
            Masters.Remove(masterModel);
        }

        internal void Load()
        {
            try
            {
                if (writableSettingsStore.PropertyExists(CollectionPath, PropertyName))
                {
                    var json = writableSettingsStore.GetString(CollectionPath, PropertyName);
                    var masters = JsonConvert.DeserializeObject<OpenShiftMaster[]>(json);
                    Masters.Clear();
                    Masters.AddRangeOnScheduler(masters.Select(m =>
                    {
                        var model = new OpenShiftMasterModel(m);
                        model.LoadProjectAsync().FireAndForget();
                        return model;
                    }));

                }
            }
            catch (Exception ex)
            {
                Debug.Fail(ex.Message);
            }
        }

        internal void Save()
        {
            try
            {
                if (!writableSettingsStore.CollectionExists(CollectionPath))
                {
                    writableSettingsStore.CreateCollection(CollectionPath);
                }

                var masters = Masters.Select(m => new OpenShiftMaster
                {
                    Name = m.Name.Value,
                    MasterUrl = m.MasterUrl.Value,
                    Token = m.Token.Value
                }).ToArray();

                var jsonString = JsonConvert.SerializeObject(masters);
                writableSettingsStore.SetString(CollectionPath, PropertyName, jsonString);
            }
            catch (Exception ex)
            {
                Debug.Fail(ex.Message);
            }
        }
    }

    public class OpenShiftMasterModel
    {
        public ReactivePropertySlim<string> Name { get; }
        public ReactivePropertySlim<string> MasterUrl { get; }
        public ReactivePropertySlim<string> Token { get; }
        public ReactiveCollection<ProjectModel> Projects { get; }

        public OpenShiftMasterModel()
        {
            Name = new ReactivePropertySlim<string>();
            MasterUrl = new ReactivePropertySlim<string>();
            Token = new ReactivePropertySlim<string>();
            Projects = new ReactiveCollection<ProjectModel>();

            
        }

        public OpenShiftMasterModel(OpenShiftMaster m)
        {
            Name = new ReactivePropertySlim<string>(m.Name);
            MasterUrl = new ReactivePropertySlim<string>(m.MasterUrl);
            Token = new ReactivePropertySlim<string>(m.Token);
            Projects = new ReactiveCollection<ProjectModel>();

            ServicePointManager.ServerCertificateValidationCallback = (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) =>
            {
                return true;
            };
        }

        internal async Task LoadProjectAsync()
        {
            try
            {
                var client = new OpenShiftAPIwithKubernetes(new Uri(MasterUrl.Value), new TokenCredentials(Token.Value));
                var projects = await client.ListProjectAsync();
                
                Projects.Clear();
                Projects.AddRangeOnScheduler(projects?
                    .Items
                    .Select(prj =>
                    {
                        var p = new ProjectModel();
                        p.Name.Value = prj.Metadata.Name;
                        LoadApps(p).FireAndForget();
                        return p;
                    }).ToArray());

                async Task LoadApps(ProjectModel prj)
                {
                    var dcList = await client.ListNamespacedDeploymentConfigAsync(prj.Name.Value);
                    prj.Apps.Clear();
                    prj.Apps.AddRangeOnScheduler(dcList?.Items.Select(dc =>
                    {
                        var app = new AppModel();
                        app.Name.Value = dc.Metadata.Name;
                        return app;
                    }));
                };
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
            }
        }
        
    }

    //JSON変換用クラス
    public class OpenShiftMaster
    {
        public string Name { get; set; }
        public string MasterUrl { get; set; }
        public string Token { get; set; }
    }

    public class ProjectModel
    {
        internal ReactivePropertySlim<string> Name { get; } = new ReactivePropertySlim<string>();
        internal ReactiveCollection<AppModel> Apps { get; } = new ReactiveCollection<AppModel>();
    }

    public class AppModel
    {
        internal ReactivePropertySlim<string> Name { get; } = new ReactivePropertySlim<string>();
    }
}
