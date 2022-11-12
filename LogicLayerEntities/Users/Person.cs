using Konscious.Security.Cryptography;
using LogicLayerEntities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LogicLayerEntities.Users
{
    public abstract class Person
    {
        private string firstName, lastName, email, phoneNumber, address, postalCode;
        private DateTime? lastModified;

        public int Id { get; set; }
        public string FirstName 
        {
            get { return firstName; }
            private set 
            {
                if(string.IsNullOrEmpty(value)) throw new ArgumentException("The field first name cannot be empty");
                if (value.Length < 3 || value.Length > 50) throw new ArgumentException("First name must have at least 3 charachters and maximum of 50 charachters");
                firstName = value;
            }
        }
        public string LastName 
        {
            get { return lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("The field last name cannot be empty");
                if (value.Length < 3 || value.Length > 50) throw new ArgumentException("Last name must have at least 3 charachters and maximum of 50 charachters");
                lastName = value;
            }
        }
        public string Email 
        {
            get { return email; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("The field email cannot be empty");
                Regex regex = new Regex(@"([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
                if(!regex.IsMatch(value)) throw new ArgumentException("Email has been entered in an incorrect format");

                email = value;
            }
        }
        public byte[] SaltPassword { get; private set; }
        public byte[] Password { get; private set; }
        public string? PhoneNumber 
        {
            get { return phoneNumber; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Regex regex = new Regex(@"^((\+|00(\s|\s?\-\s?)?)31(\s|\s?\-\s?)?(\(0\)[\-\s]?)?|0)[1-9]((\s|\s?\-\s?)?[0-9])((\s|\s?-\s?)?[0-9])((\s|\s?-\s?)?[0-9])\s?[0-9]\s?[0-9]\s?[0-9]\s?[0-9]\s?[0-9]$");
                    if (!regex.IsMatch(value)) throw new ArgumentException("Phone number has been entered in an incorrect format");
                }
                phoneNumber = value;
            }
        }
        public DateTime? LastModified { get { return lastModified; } private set { lastModified = value; } }

        public string? Address 
        {
            get { return address; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (string.IsNullOrEmpty(value)) throw new ArgumentException("The field address cannot be empty");
                    Regex regex = new Regex(@"^\A(.*?)\s+(\d+[a-zA-Z]{0,1}\s{0,1}[-]{1}\s{0,1}\d*[a-zA-Z]{0,1}|\d+[a-zA-Z-]{0,1}\d*[a-zA-Z]{0,1})");
                    if (!regex.IsMatch(value)) throw new ArgumentException("Address has been entered in an incorrect format");
                }
                address = value;
            }
        }

        public string? PostalCode 
        {
            get { return postalCode; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (string.IsNullOrEmpty(value)) throw new ArgumentException("The field zipcode cannot be empty");
                Regex regex = new Regex(@"([0-9]{4})(\s?)([a-zA-Z]{2})");
                if (!regex.IsMatch(value)) throw new ArgumentException("Zipcode has been entered in an incorrect format");
                }
                postalCode = value;
            }
        }

        public Person(string firstName, string lastName, string email, string password, string? phoneNumber, string? address, string? postalCode, DateTime? lastModified)
        {
            byte[] salt = CreateSalt();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            SaltPassword = salt;
            if (string.IsNullOrEmpty(password)) throw new ArgumentException("The field password cannot be empty");
            if (password == "DoNoTUPdaTePassWord!@#HHGTR") Password = Encoding.UTF8.GetBytes(password);
            else Password = HashPassword(password, salt);
            PhoneNumber = phoneNumber;
            Address = address;
            PostalCode = postalCode;
            LastModified = lastModified;
        }

        public Person(int id, string firstName, string lastName, string email, byte[] salt, byte[] password, string? phoneNumber, string? address, string? postalCode, DateTime? lastModified)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            SaltPassword = salt;
            Password = password;
            PhoneNumber = phoneNumber;
            Address = address;
            PostalCode = postalCode;
            LastModified = lastModified;    
        }

        public byte[] CreateSalt()
        {
            byte[] salt = new byte[16];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(salt);
            return salt;
        }
        private byte[] HashPassword(string password, byte[] salt)
        {
            Argon2id argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 8; // 4 cores of cpu
            argon2.Iterations = 4;
            argon2.MemorySize = 1024 * 1024; // 1 GB RAM

            return argon2.GetBytes(16);
        }

        public void ChangeInformation(Employee updatedEmployee, Employee currentEmployee)
        {
            FirstName = updatedEmployee.FirstName;
            LastName = updatedEmployee.LastName;
            Email = updatedEmployee.Email;
            if (Encoding.Default.GetString(updatedEmployee.Password) == "DoNoTUPdaTePassWord!@#HHGTR")
            {
                SaltPassword = currentEmployee.SaltPassword;
                Password = currentEmployee.Password;
            }
            else 
            {
                SaltPassword = updatedEmployee.SaltPassword;
                Password = updatedEmployee.Password;
            }
            PhoneNumber = updatedEmployee.PhoneNumber;
            Address = updatedEmployee.Address;
            PostalCode = updatedEmployee.PostalCode;
            currentEmployee.ChangeRole(updatedEmployee.Role);
            LastModified = updatedEmployee.LastModified;
        }

    }
}
