﻿using ModuleB.Views;
using Modules.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleB.ViewModels
{
    public class ModuleBViewModel : ViewModelBase, IModuleBViewModel
    {
        public ModuleBViewModel(IModuleBView view) : base(view)
        {
        }
    }

    public interface IModuleBViewModel : IViewModel
    {
    }
}
