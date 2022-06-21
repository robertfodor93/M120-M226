using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M120_M226.Models;
using M120_M226.ViewModels;
using M120_M226.Services;

namespace M120_M226.Commands
{
    public class GuestCreateCommand : CommandBase
    {
        private readonly GuestCreateViewModel _guestCreateViewModel;
        private readonly HotelModel _hotel;
        private readonly NavigationService _guestListVeiwNavigationService;
        public GuestCreateCommand(GuestCreateViewModel guestCreateViewModel, HotelModel hotel, NavigationService guestListVeiwNavigationService)
        {
            _guestListVeiwNavigationService = guestListVeiwNavigationService;
            _hotel = hotel;
        }
        public override void Execute(object parameter)
        {
            GuestModel guest = new GuestModel(_guestCreateViewModel.Firstname,_guestCreateViewModel.Lastname,_guestCreateViewModel.BirthDate,_guestCreateViewModel.Account);
            _hotel.CreateGuest(guest);
            _guestListVeiwNavigationService.Navigate();
        }
    }
}
