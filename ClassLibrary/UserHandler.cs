using DataAccessLayer;
using LogicLayerEntities.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LogicLayerHandlers
{
    public class UserHandler
    {
        private DBHandlerUsers dbHandlerUsers = new DBHandlerUsers();
        private List<Person> users;
        public IList<Person> Users { get { return users.AsReadOnly(); } }

        public UserHandler()
        {
            users = new List<Person>();
            users = dbHandlerUsers.GetAllUsers();

        }

        public void AddEmployee(string firstName, string lastName, string email, string phoneNumber, string role, string streetName, string houseNumber, string postalCode)
        {
            string password = RandomPassword();
            dbHandlerUsers.InsertEmployee(firstName, lastName, email, password, phoneNumber, role, streetName, houseNumber, postalCode);

            users = dbHandlerUsers.GetAllUsers();
        }

        public void AddCustomer(string firstName, string lastName, string email, string password)
        {
            dbHandlerUsers.InsertCustomer(firstName, lastName, email, password);
            users = dbHandlerUsers.GetAllUsers();
        }

        private string RandomPassword()
        {
            Random random = new Random();
            string password = "";
            string characters = "abcdefghijklmnopqrstuvwxyz";
            characters += characters.ToUpper() + "1234567890,.?@#$%&*";

            for (int x = 0; x < 10; x++)
            {
                password += characters[random.Next(characters.Length - 1)];
            }
            return password;
        }
    }
}
