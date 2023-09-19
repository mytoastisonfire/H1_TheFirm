using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff
{
    internal class Accounting:Staff
    {
        private bool _financeAccess;

        protected bool FinanceAccess { get => _financeAccess; set => _financeAccess = value; }

        protected Accounting(string firstName, string lastName, string cprNumber, int salery, string phoneNumber, bool securityAccess, bool financeAccess): base(firstName, lastName, cprNumber, salery, phoneNumber, securityAccess)
        {
            FinanceAccess = financeAccess;
        }
    }
}
