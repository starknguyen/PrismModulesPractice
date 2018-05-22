using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Infrastructure
{
    public interface IView
    {
        IViewModel ViewModel { get; set; }
    }

    public interface IViewModel
    {
        IView View { get; set; }
    }

    public class ViewModelBase : IViewModel, INotifyPropertyChanged
    {
        public IView View { get; set; }

        public ViewModelBase(IView view)
        {
            View = view;
            View.ViewModel = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
