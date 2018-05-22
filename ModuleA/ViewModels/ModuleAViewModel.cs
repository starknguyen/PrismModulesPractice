using DataModel;
using ModuleA.Views;
using Modules.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA.ViewModels
{
    public class ModuleAViewModel : ViewModelBase, IModuleAViewModel
    {
        private AvengersManager _avengers;

        public ModuleAViewModel(IModuleAView view) : base(view)
        {
            Avengers = new AvengersManager()
            {
                MemberRealName = "Tony Stark",
                MemberCodeName = "Iron Man",
                MemberUniverse = Universe.EARTH_616
            };
        }

        public AvengersManager Avengers
        {
            get { return _avengers; }
            set
            {
                _avengers = value;
                OnPropertyChanged("Avengers");
            }
        }
    }

    public interface IModuleAViewModel : IViewModel
    {
    }
}
