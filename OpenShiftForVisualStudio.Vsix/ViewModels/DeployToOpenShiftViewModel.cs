using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShiftForVisualStudio.Vsix.ViewModels
{
    public class DeployToOpenShiftViewModel
    {

        public ReactivePropertySlim<string> Title { get; }
        public AsyncReactiveCommand DeployCommand { get; }
        public ReactiveProperty<string> Message { get; } = new ReactiveProperty<string>();

        public DeployToOpenShiftViewModel()
        {
            Title = new ReactivePropertySlim<string>("example-app");

            DeployCommand = new AsyncReactiveCommand()
            .WithSubscribe(async () =>
            {
                Message.Value = "Heavy command started.";
                await Task.Delay(TimeSpan.FromSeconds(5));
                Message.Value = "Heavy command finished.";
            });
        }

        
    }
}
