using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120_M226.Models
{
    public class HotelModel
    {
        private readonly GuestListModel _guestList;
        public string Name { get; }
        public HotelModel(string name)
        {
            Name = name;
            _guestList = new GuestListModel();
        }
        public IEnumerable<GuestModel> GetAllGuests()
        {
            return _guestList.GetAllGuests();
        }
        public void CreateGuest(GuestModel guest)
        {
            _guestList.AddGuest(guest);
        }
    }
}
