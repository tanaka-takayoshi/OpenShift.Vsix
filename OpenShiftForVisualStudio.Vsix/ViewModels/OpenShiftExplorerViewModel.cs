using OpenShiftForVisualStudio.Vsix.Models;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShiftForVisualStudio.Vsix.ViewModels
{
    public class OpenShiftExplorerViewModel
    {
        public ReadOnlyReactiveCollection<OpenShiftExplorerMasterViewModel> Items { get; }

        public OpenShiftExplorerViewModel()
        {
            var model = OpenShiftMastersModel.Instance;
            Items = model.Masters.ToReadOnlyReactiveCollection(m => new OpenShiftExplorerMasterViewModel(m));
        }
        
        internal async Task LoadAsync() => await Task.WhenAll(Items.ToArray().Select(m => m.LoadAsync()).ToArray());
    }

    public class OpenShiftExplorerMasterViewModel
    {
        private OpenShiftMasterModel model;
        public ReadOnlyReactivePropertySlim<string> Name { get; }
        public ReadOnlyReactiveCollection<OpenShiftExplorerProjectViewModel> ChildItems { get; }

        public OpenShiftExplorerMasterViewModel(OpenShiftMasterModel model)
        {
            this.model = model;
            Name = model.Name.ToReadOnlyReactivePropertySlim();
            ChildItems = model.Projects.ToReadOnlyReactiveCollection(p => new OpenShiftExplorerProjectViewModel(p));
        }

        internal async Task LoadAsync() => await model.LoadProjectAsync();
    }


    public class OpenShiftExplorerProjectViewModel 
    {        
        public ReadOnlyReactivePropertySlim<string> Name { get; }
        public ReadOnlyReactiveCollection<OpenShiftExplorerAppViewModel> ChildItems { get; }
        public OpenShiftExplorerProjectViewModel(ProjectModel p)
        {
            Name = p.Name.ToReadOnlyReactivePropertySlim();
            ChildItems = p.Apps.ToReadOnlyReactiveCollection(app => new OpenShiftExplorerAppViewModel(app));
        }
    }

    public class OpenShiftExplorerAppViewModel 
    {
        public ReadOnlyReactivePropertySlim<string> Name { get; }
        public OpenShiftExplorerAppViewModel(AppModel app)
        {
            Name = app.Name.ToReadOnlyReactivePropertySlim();
        }

    }
}
