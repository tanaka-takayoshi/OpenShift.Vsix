using OpenShiftForVisualStudio.Vsix.Models;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace OpenShiftForVisualStudio.Vsix.ViewModels
{
    public class DeployToOpenShiftViewModel : IDisposable
    {
        private CompositeDisposable Disposable { get; } = new CompositeDisposable();

        private DeployToOpenShiftModel model = new DeployToOpenShiftModel();

        public ReadOnlyReactivePropertySlim<string> OpenShiftMasterUrl { get; }
        public ReactiveCollection<string> Projects { get; }
        public ReactiveProperty<string> SelectedNameSpace { get; }
        public ReactiveProperty<string> Name { get; }
        public ReactiveProperty<string> Host { get; }
        public ReactiveProperty<string> MemoryLimit { get; }
        public ReactiveProperty<string> GitSource { get; }
        public ReactiveProperty<string> GitRef { get; }
        public ReactiveProperty<string> StartupProject { get; }


        public ReadOnlyReactivePropertySlim<bool> IsDeploying { get; }

        public ReadOnlyReactivePropertySlim<string> Message { get; }

        public ReactiveCommand DeployCommand { get; }

        public DeployToOpenShiftViewModel()
        {
            OpenShiftMasterUrl = model.OpenShiftMasterUrl.ToReadOnlyReactivePropertySlim();
            Projects = new ReactiveCollection<string>
            {
                model.SelectedNameSpace.Value
            };

            Name = model.Name
                .ToReactiveProperty()
                .SetValidateAttribute(() => Name)
                .AddTo(Disposable);

            Host = model.Host
                .ToReactiveProperty()
                .SetValidateAttribute(() => Host)
                .AddTo(Disposable);

            MemoryLimit = model.MemoryLimit
                .ToReactiveProperty()
                .SetValidateAttribute(() => MemoryLimit)
                .AddTo(Disposable);

            GitSource = model.GitSource
                .ToReactiveProperty()
                .SetValidateAttribute(() => GitSource)
                .AddTo(Disposable);

            GitRef = model.GitRef
                .ToReactiveProperty()
                .SetValidateAttribute(() => GitRef)
                .AddTo(Disposable);

            StartupProject = model.StartupProject
                .ToReactiveProperty()
                .SetValidateAttribute(() => StartupProject)
                .AddTo(Disposable);

            IsDeploying = model.IsDeploying.ToReadOnlyReactivePropertySlim();

            Message = model.Message.ToReadOnlyReactivePropertySlim();

            DeployCommand = new ReactiveCommand()
            .WithSubscribe(() =>
            {
                model.StartDeploy();
            });
        }

        public void Dispose()
        {
            Disposable.Dispose();
        }
    }
}
