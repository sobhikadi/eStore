using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntities.User
{
    public enum EmployeeRoles
    {
        Admin,
        Employee
    }

    public enum SearchTypeEmployee 
    {
        FirstName,
        LastName,
        Role,
        Email
    }
}
