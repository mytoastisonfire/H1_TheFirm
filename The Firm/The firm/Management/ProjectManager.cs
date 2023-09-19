using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class ProjectManager:Manager
    {
        private string _email;

        protected string Email { get => _email; set => _email = value;}

        protected ProjectManager(string firstName, string lastName, string cprNumber, int salery, string phoneNumber, string email): base(firstName, lastName, cprNumber, salery, phoneNumber)
        {
            Email = email;
        }
    }
}
