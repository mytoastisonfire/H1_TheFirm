using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor_Staff
{
    internal class Employee
    {
        private string _firstName; 
        private string _lastName;
        private string _cprNumber;
        private int _salery;

        protected string FirstName { get => _firstName; set => _firstName = value;}
        protected string LastName { get => _lastName; set => _lastName = value;}
        protected string CprNumber { get => _cprNumber; set => _cprNumber = value;}
        protected int Salery { get => _salery; set => _salery = value;}

        protected Employee(string firstName, string lastName, string cprNumber, int salery) 
        {
            FirstName = firstName;
            LastName = lastName;
            CprNumber = cprNumber;
            Salery = salery;
        }
    }
}