using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Staff
{
    internal class Staff:Floor_Staff.Employee
    {
        private bool _securityAccess;
        private string _phoneNumber;

        protected bool SecurityAccess { get => _securityAccess; set => _securityAccess = value; }
        protected string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }

        public Staff(string firstName, string lastName, string cprNumber, int salery, string phoneNumber, bool securityAccess) :base (firstName, lastName, cprNumber, salery)
        {
            SecurityAccess = securityAccess;
            PhoneNumber = _phoneNumber;
        }
    }
}
