using Microsoft.Practices.Unity;
using ModuleA.ViewModels;
using ModuleA.Views;
using Modules.Infrastructure;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA
{
    public class ModuleAController : IModule
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;

        public ModuleAController(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterType<IModuleAViewModel, ModuleAViewModel>();
            _container.RegisterType<IModuleAView, ModuleAView>();

            _regionManager.RegisterViewWithRegion(RegionNames.LeftRegion,
                                                () => _container.Resolve<IModuleAViewModel>().View);
        }
    }
}
