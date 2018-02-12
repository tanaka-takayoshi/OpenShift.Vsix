using EnvDTE;
using EnvDTE80;
using Microsoft.Rest;
using Microsoft.VisualStudio.Shell;
using OpenShift.DotNet.Service;
using OpenShift.DotNet.Service.Models;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Reactive.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace OpenShiftForVisualStudio.Vsix.Models
{
    class DeployToOpenShiftModel
    {
        private static DTE2 _dte;

        internal static DTE2 DTE
        {
            get
            {
                if (_dte == null)
                {
                    _dte = ServiceProvider.GlobalProvider.GetService(typeof(DTE)) as DTE2;
                }

                return _dte;
            }
        }

        private OpenShiftAPIwithKubernetes client;

        internal ReactiveCollection<OpenShiftMasterModel> Masters;
        internal ReactiveProperty<OpenShiftMasterModel> SelectedMaster;

        internal ReadOnlyReactiveCollection<string> Projects;
        internal ReactiveProperty<string> SelectedProject;

        internal ReactivePropertySlim<string> Name { get; }
        internal ReactivePropertySlim<string> Host { get; }
        internal ReactivePropertySlim<string> MemoryLimit { get; }
        internal ReactivePropertySlim<string> GitSource { get; }
        internal ReactivePropertySlim<string> GitRef { get; }
        internal ReactivePropertySlim<string> StartupProject { get; }
        internal ReactivePropertySlim<bool> IsDeploying { get; } = new ReactivePropertySlim<bool>(false);

        internal ReactivePropertySlim<string> Message { get; } = new ReactivePropertySlim<string>();

        internal DeployToOpenShiftModel()
        {
            ServicePointManager.ServerCertificateValidationCallback = (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) =>
            {
                return true;
            };

            Masters = OpenShiftMastersModel.Instance.Masters;

            SelectedMaster = new ReactiveProperty<OpenShiftMasterModel>(Masters.FirstOrDefault());

            Projects = SelectedMaster
                .Where(m => !string.IsNullOrWhiteSpace(m.MasterUrl.Value) && !string.IsNullOrWhiteSpace(m.Token.Value))
                .Select(m =>
                {
                    //TODO あとでasync
                    var client = new OpenShiftAPIwithKubernetes(new Uri(m.MasterUrl.Value), new TokenCredentials(m.Token.Value));
                    var projects = client.ListProject();
                    return projects.Items.Select(p => p.Metadata.Name).ToList();
                })
                .SelectMany(x => x)
               // .SelectMany(t => t.Result)
                .ToReadOnlyReactiveCollection();

            SelectedProject = new ReactiveProperty<string>();

            Name = new ReactivePropertySlim<string>("vssdk-test");

            string branch = "";
            string gitUrl = "https://github.com/redhat-developer/s2i-dotnetcore-ex.git";
            string startupProject = "app";
            try
            {
                //DTE.ActiveSolutionProjects?.Cast<Project>().FirstOrDefault()?.FullName
                var project = DTE.SelectedItems.Item(1).Project;
                startupProject = project.Name;
                var git = new GitAnalysis(project.FullName);
                if (git.IsDiscoveredGitRepository)
                {
                    branch = git.BranchName;
                    gitUrl = git.RemoteURL;
                }
            }
            catch (Exception ex)
            {
                //Debug.Write(ex.ToString());
            }
            
            MemoryLimit = new ReactivePropertySlim<string>("512Mi");
            GitSource = new ReactivePropertySlim<string>(gitUrl); 
            GitRef = new ReactivePropertySlim<string>(branch);

            //デフォルト値はNameから自動生成
            Host = new ReactivePropertySlim<string>("vssdk-test.52.175.232.56.xip.io");
            StartupProject = new ReactivePropertySlim<string>(startupProject);
        }

        public void StartDeploy()
        {
            DeployAsync().FireAndForget();
        }

        private async Task DeployAsync()
        {
            try
            {
                var master = SelectedMaster.Value;
                //var url = "https://ose3-single-vm.westus2.cloudapp.azure.com:8443";
                var url = master.MasterUrl.Value;
                client = new OpenShiftAPIwithKubernetes(new Uri(url), new TokenCredentials(master.Token.Value));
                
                IsDeploying.Value = true;
                Message.Value = "";

                var @namespace = SelectedProject.Value;
                var name = Name.Value;
                var host = Host.Value;
                var memoeryLimit = MemoryLimit.Value;
                var gitSource = GitSource.Value;
                var gitRef = GitRef.Value;
                var startup = StartupProject.Value;

                var newRoute = await client.CreateNamespacedRouteAsync(new Comgithubopenshiftapiroutev1Route
                {
                    Metadata = new Iok8sapimachinerypkgapismetav1ObjectMeta
                    {
                        Name = name,
                        Labels = new Dictionary<string, string>
                        {
                            {"app", name}
                        }
                    },
                    Spec = new Comgithubopenshiftapiroutev1RouteSpec
                    {
                        Host = host,
                        To = new Comgithubopenshiftapiroutev1RouteTargetReference
                        {
                            Kind = "Service",
                            Name = name,
                            Weight = 100
                        }
                    },
                    Status = new Comgithubopenshiftapiroutev1RouteStatus(new Comgithubopenshiftapiroutev1RouteIngress[0])
                }, @namespace);
                Message.Value += "Created Route.\r\n";

                var newService = await client.CreateCoreV1NamespacedServiceAsync(new Iok8sapicorev1Service
                {
                    Metadata = new Iok8sapimachinerypkgapismetav1ObjectMeta
                    {
                        Name = name,
                        Labels = new Dictionary<string, string>
                        {
                            {"app", name}
                        }
                    },
                    Spec = new Iok8sapicorev1ServiceSpec
                    {
                        Ports = new[]
                        {
                            new Iok8sapicorev1ServicePort
                            {
                                Name = "web",
                                Port = 8080,
                                TargetPort = 8080
                            }
                        },
                        Selector = new Dictionary<string, string>
                        {
                            {"name", name}
                        }
                    },
                    Status = new Iok8sapicorev1ServiceStatus()
                }, @namespace);
                Message.Value += "Created Service.\r\n";

                var newImageStream = await client.CreateNamespacedImageStreamAsync(new Comgithubopenshiftapiimagev1ImageStream
                {
                    Metadata = new Iok8sapimachinerypkgapismetav1ObjectMeta
                    {
                        Name = name,
                        Labels = new Dictionary<string, string>
                        {
                            {"app", name}
                        }
                    },
                    Spec = new Comgithubopenshiftapiimagev1ImageStreamSpec(),
                    Status = new Comgithubopenshiftapiimagev1ImageStreamStatus("")
                }, @namespace);
                Message.Value += "Created ImageStream.\r\n";

                var newBuildConfig = await client.CreateNamespacedBuildConfigAsync(new Comgithubopenshiftapibuildv1BuildConfig
                {
                    Metadata = new Iok8sapimachinerypkgapismetav1ObjectMeta
                    {
                        Name = name,
                        Labels = new Dictionary<string, string>
                        {
                            {"app", name}
                        }
                    },
                    Spec = new Comgithubopenshiftapibuildv1BuildConfigSpec
                    {
                        NodeSelector = new Dictionary<string, string>(),
                        Source = new Comgithubopenshiftapibuildv1BuildSource
                        {
                            Type = "Git",
                            Git = new Comgithubopenshiftapibuildv1GitBuildSource
                            {
                                Uri = gitSource,
                                RefProperty = gitRef
                            },
                            ContextDir = ""
                        },
                        Strategy = new Comgithubopenshiftapibuildv1BuildStrategy
                        {
                            Type = "Source",
                            SourceStrategy = new Comgithubopenshiftapibuildv1SourceBuildStrategy
                            {
                                FromProperty = new Iok8sapicorev1ObjectReference
                                {
                                    Kind = "ImageStreamTag",
                                    NamespaceProperty = "openshift",
                                    Name = "dotnet:2.0",
                                },
                                Env = new[]
                                {
                                    new Iok8sapicorev1EnvVar
                                    {
                                        Name = "DOTNET_STARTUP_PROJECT",
                                        Value = startup
                                    },
                                    new Iok8sapicorev1EnvVar
                                    {
                                        Name = "DOTNET_ASSEMBLY_NAME",
                                        Value = ""
                                    },
                                    new Iok8sapicorev1EnvVar
                                    {
                                        Name = "DOTNET_NPM_TOOLS",
                                        Value = "bower gulp"
                                    },
                                    new Iok8sapicorev1EnvVar
                                    {
                                        Name = "DOTNET_TEST_PROJECTS",
                                        Value = ""
                                    },
                                    new Iok8sapicorev1EnvVar
                                    {
                                        Name = "DOTNET_CONFIGURATION",
                                        Value = "Release"
                                    },
                                    new Iok8sapicorev1EnvVar
                                    {
                                        Name = "DOTNET_PUBLISH",
                                        Value = ""
                                    },
                                    new Iok8sapicorev1EnvVar
                                    {
                                        Name = "DOTNET_RESTORE_SOURCES",
                                        Value = ""
                                    }
                                }
                            }
                        },
                        Output = new Comgithubopenshiftapibuildv1BuildOutput
                        {
                            To = new Iok8sapicorev1ObjectReference
                            {
                                Kind = "ImageStreamTag",
                                Name = $"{name}:latest"
                            }
                        },
                        Triggers = new[]
                        {
                            new Comgithubopenshiftapibuildv1BuildTriggerPolicy
                            {
                                Type = "ImageChange"
                            },
                            new Comgithubopenshiftapibuildv1BuildTriggerPolicy
                            {
                                Type = "ConfigChange"
                            }
                        }
                    },
                    Status = new Comgithubopenshiftapibuildv1BuildConfigStatus()
                }, @namespace);
                Message.Value += "Created BuildConfig.\r\n";

                var newDeploymentConfig = await client.CreateNamespacedDeploymentConfigAsync(new Comgithubopenshiftapiappsv1DeploymentConfig
                {
                    Metadata = new Iok8sapimachinerypkgapismetav1ObjectMeta
                    {
                        Name = name,
                        Labels = new Dictionary<string, string>
                        {
                            {"app", name}
                        }
                    },
                    Spec = new Comgithubopenshiftapiappsv1DeploymentConfigSpec
                    {
                        Strategy = new Comgithubopenshiftapiappsv1DeploymentStrategy
                        {
                            Type = "Rolling"
                        },
                        Triggers = new[]
                        {
                            new Comgithubopenshiftapiappsv1DeploymentTriggerPolicy
                            {
                                Type = "ImageChange",
                                ImageChangeParams = new Comgithubopenshiftapiappsv1DeploymentTriggerImageChangeParams
                                {
                                    Automatic = true,
                                    ContainerNames = new []{ "dotnet-app" },
                                    FromProperty = new Iok8sapicorev1ObjectReference
                                    {
                                        Kind = "ImageStreamTag",
                                        Name = $"{name}:latest"
                                    }
                                }
                            },
                            new Comgithubopenshiftapiappsv1DeploymentTriggerPolicy
                            {
                                Type = "ConfigChange"
                            }
                        },
                        Replicas = 1,
                        Selector = new Dictionary<string, string>
                        {
                            { "name", name }
                        },
                        Template = new Iok8sapicorev1PodTemplateSpec
                        {
                            Metadata = new Iok8sapimachinerypkgapismetav1ObjectMeta
                            {
                                Name = name,
                                Labels = new Dictionary<string, string>
                                {
                                    { "name", name }
                                }
                            },
                            Spec = new Iok8sapicorev1PodSpec
                            {
                                Containers = new[]
                                {
                                    new Iok8sapicorev1Container
                                    {
                                        Name = "dotnet-app",
                                        Image = " ",
                                        Ports = new []
                                        {
                                            new Iok8sapicorev1ContainerPort
                                            {
                                                ContainerPort = 8080
                                            }
                                        },
                                        LivenessProbe = new Iok8sapicorev1Probe
                                        {
                                            HttpGet = new Iok8sapicorev1HTTPGetAction
                                            {
                                                Path = "/",
                                                Port = 8080,
                                                Scheme = "HTTP"
                                            },
                                            InitialDelaySeconds = 40,
                                            TimeoutSeconds = 15
                                        },
                                        ReadinessProbe = new Iok8sapicorev1Probe
                                        {
                                            HttpGet = new Iok8sapicorev1HTTPGetAction
                                            {
                                                Path = "/",
                                                Port = 8080,
                                                Scheme = "HTTP"
                                            },
                                            InitialDelaySeconds = 10,
                                            TimeoutSeconds = 30
                                        },
                                        Resources = new Iok8sapicorev1ResourceRequirements
                                        {
                                            Limits = new Dictionary<string, string>
                                            {
                                                {"memory", memoeryLimit}
                                            }
                                        },
                                        Env = new Iok8sapicorev1EnvVar[]{ }
                                    }
                                }
                            }
                        }
                    },
                    Status = new Comgithubopenshiftapiappsv1DeploymentConfigStatus()
                }, @namespace);
                Message.Value += "Created DeploymentConfig.\r\n";
                Message.Value += "Depoyment succeeded.";
            }
            catch (Exception e)
            {
                Message.Value += $"Deploy failed by {e}";
            }
            finally
            {
                IsDeploying.Value = false;
            }
        }
    }
}
