using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntities.Users
{
    public class Customer : Person
    {
        public Customer() { }

        public Customer (int id, string firstName, string lastName, string email, string password) : base(id, firstName, lastName, email, password)
        {}

        public Customer(int id, string firstName, string lastName, string email, string password, string phoneNumber, string streetName, string houseNumber, string postalCode) : base(id, firstName, lastName, email, password, phoneNumber, streetName, houseNumber, postalCode)
        {
        }

    }
}
