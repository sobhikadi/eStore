using DataAccessLayer;
using Konscious.Security.Cryptography;
using LogicLayerEntities.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LogicLayerHandlers
{
    public class UserHandler
    {
        private DBHandlerUsers dbHandlerUsers = new DBHandlerUsers();
        

        public UserHandler()
        {
        }

        public IList<Person> Users { get { return dbHandlerUsers.GetAllUsers(); } }

        public void AddEmployee(Employee employee)
        {
            dbHandlerUsers.InsertEmployee(employee);
        }

        public void AddCustomer(Customer customer)
        {
            dbHandlerUsers.InsertCustomer(customer);
        }

        public string ValidateUser(string email, string password) 
        {
            
            string role = "";
            byte[] salt = dbHandlerUsers.GetSalt(email);
            if (salt == null) throw new Exception("Email or Password is incorrect");
            byte[] newPassword = HashPassword(password, salt);
            role = dbHandlerUsers.ComaparePassword(email, newPassword);
            if (string.IsNullOrEmpty(role)) throw new Exception("Email or Password is incorrect");
            return role;
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
    }
}
