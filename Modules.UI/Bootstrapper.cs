﻿using ModuleA;
using ModuleB;
using ModuleButtons;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace Modules.UI
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            ModuleCatalog catalog = new ModuleCatalog();

            catalog.AddModule(typeof(ModuleAController));
            catalog.AddModule(typeof(ModuleBController));
            catalog.AddModule(typeof(ModuleButtonsController));

            return catalog;
        }
    }
}
