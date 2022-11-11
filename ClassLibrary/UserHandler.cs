using DataAccessLayer;
using Konscious.Security.Cryptography;
using LogicLayerEntities.Products;
using LogicLayerEntities.User;
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

        private List<Person> users;

        public UserHandler()
        {
            users = new List<Person>();
            users = dbHandlerUsers.GetAllUsers();
        }

        public IList<Person> Users { get { return users.AsReadOnly(); } }

        public void AddEmployee(Employee employee)
        {
            if (GetEmployeeName(employee)) throw new Exception($"Employee with the name {employee.FirstName} already exists in database");
            int id = dbHandlerUsers.InsertEmployee(employee);
            if (id == 0) throw new ArgumentException("Employee has not been added");
            employee.Id = id;
            users.Add(employee);
        }

        public void AddCustomer(Customer customer)
        {
            int id = dbHandlerUsers.InsertCustomer(customer);
            customer.Id = id;
            users.Add(customer);
        }

        public string ValidateUser(string email, string enteredPassword) 
        {
            string role = "";
            byte[] salt = dbHandlerUsers.GetSalt(email);
            if (salt == null) return role;
            byte[] enteredPasswordHashed = HashPassword(enteredPassword, salt);
            role = dbHandlerUsers.ComaparePassword(email, enteredPasswordHashed) ;
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

        private bool GetEmployeeName(Employee employee) 
        {
            foreach (Employee emp in users) 
            {
                if (emp.FirstName == employee.FirstName) return true;
            }
            return false;
        }

        public IList<Employee> SearchEmployee(string term, SearchTypeEmployee type)
        {
            return dbHandlerUsers.SearchEmployee(term, type);
        }
    }
}
