using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntities.Users
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string? PhoneNumber { get; private set; }
        public string? Address { get; private set; }
        public string? PostalCode { get; private set; }

        public Person(string firstName, string lastName, string email, string password, string? phoneNumber, string? address, string? postalCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Address = address;
            PostalCode = postalCode;
        }

        public Person(int id, string firstName, string lastName, string email, string password, string? phoneNumber, string? address, string? postalCode)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Address = address;
            PostalCode = postalCode;
        }


    }
}
