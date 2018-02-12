using Microsoft.VisualStudio.Shell;
using OpenShiftForVisualStudio.Vsix.ViewModels;
using OpenShiftForVisualStudio.Vsix.Views;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows;

namespace OpenShiftForVisualStudio.Vsix.Options
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("633722D6-3A5C-497A-AE46-8D6A8320D90C")]
    public sealed class OpenShiftMasterEndpointSetting : UIElementDialogPage
    {
        private readonly OpenShiftMasterEndpointSettingsViewModel viewModel;
        private readonly OpenShiftMasterEndpointSettingsView view;

        protected override UIElement Child => view;

        public OpenShiftMasterEndpointSetting()
        {
            viewModel = new OpenShiftMasterEndpointSettingsViewModel();
            view = new OpenShiftMasterEndpointSettingsView
            {
                DataContext = viewModel
            };
        }

        public override void LoadSettingsFromStorage()
        {
            viewModel.LoadAsync().GetAwaiter().GetResult();
            base.LoadSettingsFromStorage();
        }

        protected override void OnClosed(EventArgs e)
        {

            base.OnClosed(e);
        }

        public override void SaveSettingsToStorage()
        {
            viewModel.SaveAsync().GetAwaiter().GetResult();
            base.SaveSettingsToStorage();
        }

        public override void ResetSettings()
        {
            base.ResetSettings();
        }

        protected override void OnActivate(CancelEventArgs e)
        {
            base.OnActivate(e);
        }

        protected override void OnDeactivate(CancelEventArgs e)
        {
            base.OnDeactivate(e);
        }
    }
}
