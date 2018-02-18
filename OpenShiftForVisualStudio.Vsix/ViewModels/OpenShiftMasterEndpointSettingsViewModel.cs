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

        public ReadOnlyReactivePropertySlim<bool> IsSelected { get; }

        public OpenShiftMasterEndpointSettingsViewModel()
        {
            model = OpenShiftMastersModel.Instance;
            Masters = model.Masters.ToReadOnlyReactiveCollection(m => new OpenShiftMasterViewModel(m));

            AddItemCommand = new ReactiveCommand()
                .WithSubscribe(async () =>
                {
                    var newMaster = new OpenShiftMasterModel();
                    model.AddItem(newMaster);
                    var added = await Masters.ObserveAddChanged().FirstAsync();
                    SelectedItem.Value = added;
                })
                .AddTo(Disposable);
            
            RemoveItemCommand = SelectedItem
                .Select(item => item != null)
                .ToReactiveCommand()
                .WithSubscribe(() => model.DeleteItem(SelectedItem.Value.Model))
                .AddTo(Disposable);

            CanSave = Masters.Select(m => m.HasErrors).CombineLatestValuesAreAllFalse().ToReactiveProperty();

            IsSelected = SelectedItem
                .Select(item => item != null)
                .ToReadOnlyReactivePropertySlim(false);
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

        public ReactiveCommand LoadFromLoginCommand { get; }
        public ReactiveProperty<string> LoginCommand { get; } = new ReactiveProperty<string>();

        private ReactiveProperty<bool> hasErrors;
        public ReactiveProperty<bool> HasErrors =>
            hasErrors ?? (hasErrors = Observable.CombineLatest(
                Name.ObserveHasErrors.Throttle(TimeSpan.FromMilliseconds(500)),
                Endpoint.ObserveHasErrors.Throttle(TimeSpan.FromMilliseconds(500)),
                Token.ObserveHasErrors.Throttle(TimeSpan.FromMilliseconds(500)))
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

            LoadFromLoginCommand = LoginCommand
                .Select(Parse)
                .Select(x => x.succeeded)
                .ToReactiveCommand(false)
                .WithSubscribe(() =>
                {
                    var command = LoginCommand.Value;
                    var (succeeded, url, token) = Parse(command);
                    if (succeeded)
                    {
                        Endpoint.Value = url;
                        Token.Value = token;
                    }
                }).AddTo(Disposable);
        }

        private static (bool succeeded, string url, string token) Parse(string command)
        {
            var elemetns = command?.Split(' ');
            if ((elemetns?.Length ?? 0) < 4 || elemetns[0] != "oc" || elemetns[1] != "login")
                return (false, null, null);
            if (elemetns[3].StartsWith("--token="))
            {
                return (true, elemetns[2], elemetns[3].Remove(0, "--token=".Length));
            }
            if (elemetns[3] == ("--token") && elemetns.Length >= 5)
            {
                return (true, elemetns[2], elemetns[4]);
            }
            return (false, null, null);
        }
    }
}
