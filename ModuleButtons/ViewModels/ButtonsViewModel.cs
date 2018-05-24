using ModuleButtons.Views;
using Modules.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleButtons.ViewModels
{
    public class ButtonsViewModel : ViewModelBase, IButtonsViewModel
    {
        public ButtonsViewModel(IButtonsView view) : base(view)
        {
        }
    }

    public interface IButtonsViewModel : IViewModel
    {
    }
}
