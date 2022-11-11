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

        public Employee(string firstName, string lastName, string email, string password, string phoneNumber, string address, string postalCode, string role, DateTime? lastModified) : base(firstName, lastName, email, password, phoneNumber, address, postalCode, lastModified)
        {
            Role = role;
        }

        public Employee(int id, string firstName, string lastName, string email, byte[] salt, byte[] password, string phoneNumber, string address, string postalCode, string role, DateTime? lastModified) : base(id, firstName, lastName, email,salt, password, phoneNumber, address, postalCode, lastModified)
        {
            Role = role;
        }
        public void ChangeRole(string role) 
        {
            Role = role;
        }
    }
}
