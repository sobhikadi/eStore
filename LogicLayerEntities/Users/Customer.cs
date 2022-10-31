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

        public Customer(string firstName, string lastName, string email, string password, string? phoneNumber, string? address, string? postalCode, string? billingAddress, string? billingPostalCode) : base(firstName, lastName, email, password, phoneNumber, address, postalCode)
        {
            BillingAddress = billingAddress;
            BillingPostalCode = billingPostalCode;
        }

        public Customer(int id, string firstName, string lastName, string email, string? phoneNumber, string? address, string? postalCode, string? billingAddress, string? billingPostalCode) : base(id, firstName, lastName, email, phoneNumber, address, postalCode)
        {
            BillingAddress = billingAddress;
            BillingPostalCode = billingPostalCode;
        }
    }
}
