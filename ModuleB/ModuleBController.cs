using Microsoft.Practices.Unity;
using ModuleB.ViewModels;
using ModuleB.Views;
using Modules.Infrastructure;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleB
{
    public class ModuleBController : IModule
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;

        public ModuleBController(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterType<IModuleBViewModel, ModuleBViewModel>();
            _container.RegisterType<IModuleBView, ModuleBView>();

            IRegion region = _regionManager.Regions[RegionNames.RightRegion];
            region.Add(_container.Resolve<IModuleBViewModel>().View);
        }
    }
}
