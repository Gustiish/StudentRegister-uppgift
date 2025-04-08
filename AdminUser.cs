using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift
{
    public class AdminUser : IAdminActions
    {
        public int AdminUserId { get; set; }

        public string AdminUserName { get; set; }
        public int AdminPassword { get; set; }
        public bool IsAdmin { get; set; }

    
        public bool LoginCheck(int passcode)
        {
            if (AdminPassword == passcode) return true;
            else return false;
        }

    }
}
