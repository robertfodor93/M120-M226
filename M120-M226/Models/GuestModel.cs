using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120_M226.Models
{
    public class GuestModel
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public DateTime BirthDate { get; }
        public int Account { get; }

        public GuestModel(string firtname, string lastname, DateTime birthDate, int account)
        {
            Firstname = firtname;
            Lastname = lastname;
            BirthDate = birthDate;
            Account = account;
        }
    }
}
