using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift
{
    public interface IAdminActions
    {
        bool LoginCheck(int passcode);
    }
}
