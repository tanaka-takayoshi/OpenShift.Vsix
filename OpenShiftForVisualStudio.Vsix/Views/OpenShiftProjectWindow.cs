namespace OpenShiftForVisualStudio.Vsix.Views
{
    using System;
    using System.ComponentModel.Design;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.Shell.Interop;
    using OpenShiftForVisualStudio.Vsix.ViewModels;

    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("2cabd406-e197-4c6a-a3f8-d8de4458a4a9")]
    //[ProvideToolWindow(typeof(OpenShiftProjectWindow), Style = VsDockStyle.Tabbed, Orientation =ToolWindowOrientation.Left)]
    public class OpenShiftProjectWindow : ToolWindowPane
    {
        public OpenShiftProjectWindowControl control;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenShiftProjectWindow"/> class.
        /// </summary>
        public OpenShiftProjectWindow() : base(null)
        {
            this.Caption = "OpenShift Project Explorer";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            var vm = new OpenShiftExplorerViewModel();
            control = new OpenShiftProjectWindowControl()
            {
                DataContext = vm
            };
            this.Content = control;
            vm.LoadAsync().FireAndForget();

            this.ToolBar = new CommandID(OpenShiftProjectWindowCommand.CommandSet,
                    OpenShiftProjectWindowCommand.ToolbarID);
            this.ToolBarLocation = (int)VSTWT_LOCATION.VSTWT_TOP;
        }
    }
}
