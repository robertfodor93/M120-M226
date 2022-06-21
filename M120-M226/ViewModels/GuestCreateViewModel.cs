using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using M120_M226.Commands;
using M120_M226.Models;
using M120_M226.Services;

namespace M120_M226.ViewModels
{
    public class GuestCreateViewModel : ViewModelBase
    {
        private string _firstname;
        public string Firstname
        {
            get 
            { 
                return _firstname; 
            }
            set { 
                _firstname = value;
                OnPropertyChanged(nameof(Firstname));
            }
        }
        private string _lastname;
        public string Lastname
        {
            get 
            { 
                return _lastname; 
            }
            set 
            { 
                _lastname = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }
        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get 
            { 
                return _birthDate; 
            }
            set
            { 
                _birthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }
        private int _account;
        public int Account
        {
            get
            {
                return _account;
            }
            set
            {
                _account = value;
                OnPropertyChanged(nameof(Account));
            }
        }
        public ICommand SubmitCommand { get; }
        public ICommand GuestListCommand { get; }

        public GuestCreateViewModel(HotelModel hotel, NavigationService guestListVeiwNavigationService)
        {
            SubmitCommand = new GuestCreateCommand(this, hotel, guestListVeiwNavigationService);
            GuestListCommand = new NavigateCommand(guestListVeiwNavigationService);
        }
    }
}
