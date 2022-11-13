using LogicLayerEntities.User;
using LogicLayerEntities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDBMediatorUser
    {
        public int InsertEmployee(Employee employee);

        public int InsertCustomer(Customer customer);

        public List<Person> GetAllUsers();

        public byte[] GetSalt(string email);

        public string ComaparePassword(string email, byte[] password);

        public IList<Employee> SearchEmployee(string term, SearchTypeEmployee type);

        public bool UpdateEmployee(Employee newEmployee, Employee currentEmployee);

        public bool CheckIfEmployeeModified(Employee currentEmployee);

        public bool DeleteEmployee(Employee employee);
    }
}
