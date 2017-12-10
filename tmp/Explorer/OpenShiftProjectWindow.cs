namespace OpenShiftForVisualStudio.Vsix.Explorer
{
    using System;
    using System.ComponentModel.Design;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.Shell.Interop;

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
    [Guid("eba945c0-3c31-48c6-87a7-980b5ebaf3f6")]
    //[ProvideToolWindow(typeof(OpenShiftProjectWindow),
    //Style = VsDockStyle.Tabbed)]
    public class OpenShiftProjectWindow : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenShiftProjectWindow"/> class.
        /// </summary>
        public OpenShiftProjectWindow() : base(null)
        {
            this.Caption = "OpenShiftProjectWindow";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new OpenShiftProjectWindowControl();

            this.ToolBar = new CommandID(OpenShiftProjectWindowCommand.CommandSet,
                    OpenShiftProjectWindowCommand.ToolbarID);
            this.ToolBarLocation = (int)VSTWT_LOCATION.VSTWT_TOP;
        }
    }
}
