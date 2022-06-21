using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using M120_M226.Models;

namespace M120_M226.ViewModels
{
    public class GuestViewModel: ViewModelBase
    {
        private readonly GuestModel _guest;

        public string Firstname => _guest.Firstname;
        public string Lastname => _guest.Lastname;
        public DateTime BirthDate => _guest.BirthDate;
        public int Account => _guest.Account;

        public GuestViewModel(GuestModel guest)
        {
            _guest = guest;
        }
    }
}
