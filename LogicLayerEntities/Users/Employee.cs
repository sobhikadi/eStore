using LogicLayerEntities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntities.Users
{
    public class Employee : Person
    {
        
        public string Role { get; private set; }

        public Employee(string firstName, string lastName, string email, string password, string phoneNumber, string address, string postalCode, string role) : base(firstName, lastName, email, password, phoneNumber, address, postalCode)
        {
            Role = role;
        }

        public Employee(int id, string firstName, string lastName, string email, string phoneNumber, string address, string postalCode, string role) : base(id, firstName, lastName, email, phoneNumber, address, postalCode)
        {
            Role = role;
        }
    }
}
