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

        public Employee(int id, string firstName, string lastName, string email, string password, string phoneNumber, string streetName, string houseNumber, string postalCode, string role) : base(id, firstName, lastName, email, password, phoneNumber, streetName, houseNumber, postalCode)
        {
            Role = role;
        }
    }
}
