using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120_M226.Models
{
    public class GuestListModel
    {
        private readonly List<GuestModel> _guestList;

        public GuestListModel()
        {
            _guestList = new List<GuestModel>();
        }
        public void AddGuest(GuestModel guest)
        {
            _guestList.Add(guest);
        }
        public IEnumerable<GuestModel> GetAllGuests()
        {
            return _guestList;
        }
    }
}
