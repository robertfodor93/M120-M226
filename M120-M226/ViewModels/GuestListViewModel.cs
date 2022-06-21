using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using M120_M226.Models;
using M120_M226.Stores;
using M120_M226.Commands;
using M120_M226.Services;

namespace M120_M226.ViewModels
{
    public class GuestListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<GuestViewModel> _guests;
        public IEnumerable<GuestViewModel> Guests => _guests;
        public ICommand GuestCreateCommand { get; }
        public GuestListViewModel(NavigationService guestCreateNavigationService)
        {
            GuestCreateCommand = new NavigateCommand(guestCreateNavigationService);
            _guests = new ObservableCollection<GuestViewModel>();
            _guests.Add(new GuestViewModel(new GuestModel("Robert", "Fodor", DateTime.Now, 54334)));
        }
    }
}
