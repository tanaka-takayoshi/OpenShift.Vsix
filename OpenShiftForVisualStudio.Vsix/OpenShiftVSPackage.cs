﻿using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Win32;
using OpenShiftForVisualStudio.Vsix.Options;

namespace OpenShiftForVisualStudio.Vsix
{
    /// <summary>
    /// This is the class that implements the package exposed by this assembly.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The minimum requirement for a class to be considered a valid package for Visual Studio
    /// is to implement the IVsPackage interface and register itself with the shell.
    /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
    /// to do it: it derives from the Package class that provides the implementation of the
    /// IVsPackage interface and uses the registration attributes defined in the framework to
    /// register itself and its components with the shell. These attributes tell the pkgdef creation
    /// utility what data to put into .pkgdef file.
    /// </para>
    /// <para>
    /// To get loaded into VS, the package must be referred by &lt;Asset Type="Microsoft.VisualStudio.VsPackage" ...&gt; in .vsixmanifest file.
    /// </para>
    /// </remarks>
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [Guid(OpenShiftVSPackage.PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [ProvideToolWindow(typeof(OpenShiftForVisualStudio.Vsix.Views.OpenShiftProjectWindow))]
    //[ProvideProfile(typeof(AvaloniaDesignerGeneralPage), "Avalonia designer", "Avalonia Designer Options", 289, 289, true, DescriptionResourceID = 114)]
    [ProvideOptionPage(typeof(OpenShiftMasterEndpointSetting), "OpenShift Tools for Visual Studio", "Master endpoints", 0, 0, true)]
    public sealed class OpenShiftVSPackage : Package
    {
        /// <summary>
        /// OpenShiftVSPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "7ac97a1f-70b2-4e73-9173-f9c553219362";

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenShiftVSPackage"/> class.
        /// </summary>
        public OpenShiftVSPackage()
        {
            // Inside this method you can place any initialization code that does not require
            // any Visual Studio service because at this point the package object is created but
            // not sited yet inside Visual Studio environment. The place to do all the other
            // initialization is the Initialize method.
        }

        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialization code that rely on services provided by VisualStudio.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
            OpenShiftForVisualStudio.Vsix.Views.OpenShiftProjectWindowCommand.Initialize(this);
            OpenShiftForVisualStudio.Vsix.DeployToOpenShiftCommand.Initialize(this);
        }

        #endregion
        
        static OpenShiftVSPackage()
        {
            RedirectAssembly("System.Reactive.Core", new Version(3, 0, 3000, 0), "94bc3704cddfc263");
            RedirectAssembly("System.Reactive.Interfaces", new Version(3, 0, 1000, 0), "94bc3704cddfc263");
            //RedirectAssembly("Newtonsoft.Json", new Version(10, 0, 0, 0), "30ad4fe6b2a6aeed");
            //RedirectAssembly("System.Reactive.Core", new Version(4, 1, 1, 2), "b03f5f7f11d50a3a");
        }

        public static void RedirectAssembly(string shortName, Version targetVersion, string publicKeyToken)
        {
            ResolveEventHandler handler = null;

            handler = (sender, args) => {
                // Use latest strong name & version when trying to load SDK assemblies
                var requestedAssembly = new AssemblyName(args.Name);
                if (requestedAssembly.Name != shortName)
                    return null;

                Debug.WriteLine($"Redirecting assembly load of {args.Name}, loaded by {args.RequestingAssembly?.FullName ?? "(unknown)"}");
                
                if (requestedAssembly.Version > targetVersion)
                {
                    Debug.WriteLine($"Request assemby's version {requestedAssembly.Version} is higher than the target version {targetVersion}. Stop to load the target assembly.");
                    return null;
                }
                requestedAssembly.Version = targetVersion;
                requestedAssembly.SetPublicKeyToken(new AssemblyName($"x, PublicKeyToken={publicKeyToken}").GetPublicKeyToken());
                requestedAssembly.CultureInfo = CultureInfo.InvariantCulture;

                AppDomain.CurrentDomain.AssemblyResolve -= handler;

                return Assembly.Load(requestedAssembly);
            };
            AppDomain.CurrentDomain.AssemblyResolve += handler;
        }
    }

    public static class TaskEx
    {
        /// <summary>
        /// 投げっぱなしにする場合は、これを呼ぶことでコンパイラの警告の抑制と、例外発生時のロギングを行います。
        /// </summary>
        public static void FireAndForget(this System.Threading.Tasks.Task task)
        {
            task.ContinueWith(x =>
            {
                Debug.Write(x.Exception);
                //logger.ErrorException("TaskUnhandled", x.Exception);
            }, TaskContinuationOptions.OnlyOnFaulted);
        }
    }
    
}
