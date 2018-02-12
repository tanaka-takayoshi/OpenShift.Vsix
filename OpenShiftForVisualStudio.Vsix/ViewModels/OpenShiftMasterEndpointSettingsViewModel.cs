using OpenShiftForVisualStudio.Vsix.Models;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShiftForVisualStudio.Vsix.ViewModels
{
    public class OpenShiftMasterEndpointSettingsViewModel : IDisposable
    {
        private readonly OpenShiftMastersModel model;

        private CompositeDisposable Disposable { get; } = new CompositeDisposable();

        public ReadOnlyReactiveCollection<OpenShiftMasterViewModel> Masters { get; }
        public ReactivePropertySlim<OpenShiftMasterViewModel> SelectedItem { get; } = new ReactivePropertySlim<OpenShiftMasterViewModel>();
        public ReactiveProperty<bool> CanSave { get; }

        public ReactiveCommand AddItemCommand { get; }

        public ReactiveCommand RemoveItemCommand { get; }

        public OpenShiftMasterEndpointSettingsViewModel()
        {
            model = OpenShiftMastersModel.Instance;
            Masters = model.Masters.ToReadOnlyReactiveCollection(m => new OpenShiftMasterViewModel(m));

            AddItemCommand = new ReactiveCommand()
                .WithSubscribe(() =>
                {
                    var newMaster = new OpenShiftMasterModel();
                    model.AddItem(newMaster);
                    SelectedItem.Value = Masters.FirstOrDefault(m => m.Model == newMaster);
                })
                .AddTo(Disposable);
            
            RemoveItemCommand = SelectedItem
                .Select(item => item != null)
                .ToReactiveCommand()
                .WithSubscribe(() => model.DeleteItem(SelectedItem.Value.Model))
                .AddTo(Disposable);

            CanSave = Masters.Select(m => m.HasErrors).CombineLatestValuesAreAllFalse().ToReactiveProperty();
        }

        public async Task SaveAsync()
        {
            if (Masters.Any(m => m.HasErrors.Value))
            {
                return;
            }
            model.Save();
        }

        public async Task LoadAsync()
        {
            model.Load();
        }

        public void Dispose()
        {
            Disposable.Dispose();
        }
    }

    public class OpenShiftMasterViewModel
    {
        private CompositeDisposable Disposable { get; } = new CompositeDisposable();

        public OpenShiftMasterModel Model { get; }
        [Required]
        public ReactiveProperty<string> Name { get; }
        [Required]
        public ReactiveProperty<string> Endpoint { get; }
        [Required]
        public ReactiveProperty<string> Token { get; }

        private ReactiveProperty<bool> hasErrors;
        public ReactiveProperty<bool> HasErrors =>
            hasErrors ?? (hasErrors = Observable.CombineLatest(
                Name.ObserveHasErrors,
                Endpoint.ObserveHasErrors,
                Token.ObserveHasErrors)
                .Select(x => x.Any(y => y))
                .ToReactiveProperty());


        public OpenShiftMasterViewModel(OpenShiftMasterModel model)
        {
            Model = model;
            Name = Model
                .Name
                .ToReactivePropertyAsSynchronized(x => x.Value)
                .SetValidateAttribute(() => Name)
                .AddTo(Disposable);

            Endpoint = Model.MasterUrl
                .ToReactivePropertyAsSynchronized(x => x.Value)
                .SetValidateAttribute(() => Endpoint)
                .AddTo(Disposable);

            Token = Model.Token
                .ToReactivePropertyAsSynchronized(x => x.Value)
                .SetValidateAttribute(() => Token)
                .AddTo(Disposable);
        }
    }
}
