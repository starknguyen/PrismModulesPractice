using Microsoft.Practices.Unity;
using ModuleButtons.ViewModels;
using ModuleButtons.Views;
using Modules.Infrastructure;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleButtons
{
    public class ModuleButtonsController : IModule
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;

        public ModuleButtonsController(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterType<IButtonsViewModel, ButtonsViewModel>();
            _container.RegisterType<IButtonsView, ButtonsView>();

            IRegion region = _regionManager.Regions[RegionNames.BottomRegion];
            region.Add(_container.Resolve<IButtonsViewModel>().View);
        }
    }
}
