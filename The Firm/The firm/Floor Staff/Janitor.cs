using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor_Staff
{
    internal class Janitor:Employee
    {
        private byte _litersOfSoapUsed;

        protected byte LitersOfSoapUsed { get => _litersOfSoapUsed; set => _litersOfSoapUsed = value; }

        protected Janitor(string firstName, string lastName, string cprNumber, int salery, byte litersOfSoapUsed): base(firstName, lastName, cprNumber, salery)
        {
            LitersOfSoapUsed = litersOfSoapUsed;
        }
    }
}
