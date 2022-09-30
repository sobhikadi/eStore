using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Users
{
    public abstract class SystemUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? StreetName { get; set; }
        public string? HouseNumber { get; set; }
        public string? PostalCode { get; set; }

        public SystemUser() { }

        public SystemUser(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
        public SystemUser(int id, string firstName, string lastName, string email, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        public SystemUser(string firstName, string lastName, string email, string password, string phoneNumber, string streetName, string houseNumber, string postalCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            StreetName = streetName;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
        }

        public SystemUser(int id, string firstName, string lastName, string email, string password, string phoneNumber, string streetName, string houseNumber, string postalCode)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            StreetName = streetName;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
        }


    }
}
