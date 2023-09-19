using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class Director:ProjectManager
    {
        private int _pension401k;

        protected int Pension401k { get => _pension401k; set => _pension401k = value; }

        protected Director(string firstName, string lastName, string cprNumber, int salery, string phoneNumber, string email, int pension401k): base(firstName, lastName, cprNumber, salery, phoneNumber, email)
        {
            Pension401k = pension401k;
        }
    }
}
