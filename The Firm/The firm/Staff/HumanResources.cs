using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff
{
    internal class HumanResources:Staff
    {
        private bool _gdprAccess;
        protected bool GdprAccess { get => _gdprAccess; set => _gdprAccess = value; }
        protected HumanResources(string firstName, string lastName, string cprNumber, int salery, string phoneNumber, bool securityAccess, bool gdprAccess): base(firstName, lastName, cprNumber, salery, phoneNumber, securityAccess)
        {
            GdprAccess = gdprAccess;
        }
    }
}
