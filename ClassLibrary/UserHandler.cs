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

        public void AddEmployee(Employee employee)
        {
            int id = dbHandlerUsers.InsertEmployee(employee);
            employee.Id = id;
            users.Add(employee);
        }

        public void AddCustomer(Customer customer)
        {
            int customerId = dbHandlerUsers.InsertCustomer(customer);
            customer.Id = customerId;
            users.Add(customer);
        }

    }
}
