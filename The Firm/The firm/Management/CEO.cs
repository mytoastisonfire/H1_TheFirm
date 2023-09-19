using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class CEO:Director
    {
        private bool _ceoAccess;

        protected bool CeoAccess { get => _ceoAccess; set => _ceoAccess = value; }

        protected CEO(string firstName, string lastName, string cprNumber, int salery, string phoneNumber, string email, int pension401k, bool ceoAccess): base(firstName, lastName, cprNumber, salery, phoneNumber, email, pension401k)
        {
            CeoAccess = ceoAccess;
        }
    }
}
