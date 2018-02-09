using OpenShiftForVisualStudio.Vsix.Models;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShiftForVisualStudio.Vsix.ViewModels
{
    public class DeployToOpenShiftViewModel : IDisposable
    {
        private CompositeDisposable Disposable { get; } = new CompositeDisposable();

        private DeployToOpenShiftModel model = new DeployToOpenShiftModel();

        public ReadOnlyReactiveCollection<OpenShiftMasterViewModel> Masters { get; }
        public ReactivePropertySlim<OpenShiftMasterViewModel> SelectedMaster { get; }
        
        public ReadOnlyReactiveCollection<string> Projects { get; }
        public ReactiveProperty<string> SelectedNameSpace { get; }

        [RegularExpression(@"[a-z-\.]{1,253}")]
        [Required]
        public ReactiveProperty<string> Name { get; }

        [Required]
        public ReactiveProperty<string> Host { get; }

        [Required]
        public ReactiveProperty<string> MemoryLimit { get; }
        [Required]
        public ReactiveProperty<string> GitSource { get; }
        [Required]
        public ReactiveProperty<string> GitRef { get; }
        public ReactiveProperty<string> StartupProject { get; }


        public ReadOnlyReactivePropertySlim<bool> IsDeploying { get; }

        public ReadOnlyReactivePropertySlim<string> Message { get; }

        public ReactiveCommand DeployCommand { get; }

        public DeployToOpenShiftViewModel()
        {
            Masters = model.Masters.ToReadOnlyReactiveCollection(m => new OpenShiftMasterViewModel(m));
            SelectedMaster = new ReactivePropertySlim<OpenShiftMasterViewModel>();
            SelectedMaster
                .Where(x => x != null)
                .Subscribe(x => model.SelectedMaster.Value = x.Model)
                .AddTo(Disposable);

            Projects = model.Projects.ToReadOnlyReactiveCollection();
            SelectedNameSpace = model.SelectedProject.ToReactivePropertyAsSynchronized(x => x.Value);

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

            DeployCommand = SelectedMaster.Select(s => s != null)
                .ToReactiveCommand()
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
