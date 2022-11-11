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
        public string? BillingAddress{ get; private set; }
        public string? BillingPostalCode { get; private set; }

        public Customer(string firstName, string lastName, string email, string password, string? phoneNumber, string? address, string? postalCode, string? billingAddress, string? billingPostalCode, DateTime? lastModified) : base(firstName, lastName, email, password, phoneNumber, address, postalCode, lastModified)
        {
            BillingAddress = billingAddress;
            BillingPostalCode = billingPostalCode;
        }

        public Customer(int id, string firstName, string lastName, string email,byte[] salt, byte[] password, string? phoneNumber, string? address, string? postalCode, string? billingAddress, string? billingPostalCode, DateTime? lastModified) : base(id, firstName, lastName, email,salt, password, phoneNumber, address, postalCode, lastModified)
        {
            BillingAddress = billingAddress;
            BillingPostalCode = billingPostalCode;
        }
    }
}
