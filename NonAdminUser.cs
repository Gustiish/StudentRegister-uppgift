using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift
{
    public class NonAdminUser : IAdminActions
    {
        public int NonAdminUserId { get; set; }
        public string NonAdminUserName { get; set; }
        public int NonAdminPassword { get; set; }
        public bool IsAdmin { get; set; }

        public bool LoginCheck(int passcode)
        {
            if (NonAdminPassword == passcode) return true;
            else return false;
        }

    }
}
