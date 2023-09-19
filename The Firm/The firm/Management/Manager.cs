using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class Manager:Floor_Staff.Employee
    {
        private string _phoneNumber;

        protected string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }

        protected Manager(string firstName, string lastName, string cprNumber, int salery, string phoneNumber) : base(firstName, lastName, cprNumber, salery)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
