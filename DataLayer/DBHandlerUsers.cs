using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net;
using LogicLayerEntities.Users;
using LogicLayerEntities.Products;
using LogicLayerEntities.User;
using System.Data;

namespace DataAccessLayer
{
    public class DBHandlerUsers : IDBMediatorUser
    {
        private string connectionString = "server=mssqlstud.fhict.local;" + "database=dbi376372;" + "user id=dbi376372;" + "password=Mky3S[elWm;" + "connect timeout=30;";


        public int InsertEmployee(Employee employee)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string sql = "insert into Users (firstName, lastName, email, salt, password, phoneNumber, address, postalCode, LastModified) values (@firstName, @lastName, @email, @salt, @password, @phoneNumber, @address, @postalCode, @LastModified); select SCOPE_IDENTITY(); insert into Employee (id, role) values (SCOPE_IDENTITY(), @role)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@salt", employee.SaltPassword);
                cmd.Parameters.AddWithValue("@password", employee.Password);
                cmd.Parameters.AddWithValue("@phoneNumber", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", employee.Address);
                cmd.Parameters.AddWithValue("@postalCode", employee.PostalCode);
                cmd.Parameters.AddWithValue("@role", employee.Role);
                cmd.Parameters.AddWithValue("@LastModified", DBNull.Value);


                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read()) id = Convert.ToInt32(dr[0]);

                conn.Close();
            }
            return id;
        }

        public int InsertCustomer(Customer customer)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "insert into Users (firstName, lastName, email, salt, password, phoneNumber, address, postalCode, lastModified) values (@firstName, @lastName, @email, @salt, @password, @phoneNumber, @address, @postalCode, @LastModified); select SCOPE_IDENTITY(); insert into Customer (id, billingAddress, billingPostalCode) values (SCOPE_IDENTITY(), @billingAddress, @billingPostalCode)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@firstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@lastName", customer.LastName);
                cmd.Parameters.AddWithValue("@email", customer.Email);
                cmd.Parameters.AddWithValue("@salt", customer.SaltPassword);
                cmd.Parameters.AddWithValue("@password", customer.Password);
                cmd.Parameters.AddWithValue("@LastModified", DBNull.Value);

                if (!string.IsNullOrEmpty(customer.PhoneNumber)) cmd.Parameters.AddWithValue("@phoneNumber", customer.PhoneNumber);
                else cmd.Parameters.AddWithValue("@phoneNumber", DBNull.Value);
                if (!string.IsNullOrEmpty(customer.Address)) cmd.Parameters.AddWithValue("@address", customer.Address);
                else cmd.Parameters.AddWithValue("@address", DBNull.Value);
                if (!string.IsNullOrEmpty(customer.PostalCode)) cmd.Parameters.AddWithValue("@postalCode", customer.PostalCode);
                else cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                if (!string.IsNullOrEmpty(customer.BillingAddress)) cmd.Parameters.AddWithValue("@billingAddress", customer.BillingAddress);
                else cmd.Parameters.AddWithValue("@billingAddress", DBNull.Value);
                if (!string.IsNullOrEmpty(customer.BillingPostalCode)) cmd.Parameters.AddWithValue("@billingPostalCode", customer.BillingPostalCode);
                else cmd.Parameters.AddWithValue("@billingPostalCode", DBNull.Value);
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) id = Convert.ToInt32(dr[0]);
                conn.Close();
            }
            return id;
        }

        public List<Person> GetAllUsers()
        {
            List<Person> users = new List<Person>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                conn.Open();
                string sqlCus =
                    " select users.id, firstName, lastName, email, salt, Password, phoneNumber, Address, postalCode, LastModified, BillingAddress, billingPostalCode from users inner join Customer on users.Id = Customer.Id order by users.id;";

                SqlCommand cmdCus = new SqlCommand(sqlCus, conn);

                SqlDataReader drCus = cmdCus.ExecuteReader();

                while (drCus.Read())
                {
                    string? phoneNumber, address, postalCode, billingAddress, billingPostalCode;
                    DateTime? lastModified;
                    if (drCus["phoneNumber"] != DBNull.Value) phoneNumber = (string)drCus["phoneNumber"];
                    else phoneNumber = null;
                    if (drCus["address"] != DBNull.Value) address = (string)drCus["address"];
                    else address = null;
                    if (drCus["postalCode"] != DBNull.Value) postalCode = (string)drCus["postalCode"];
                    else postalCode = null;
                    if (drCus["billingAddress"] != DBNull.Value) billingAddress = (string)drCus["billingAddress"];
                    else billingAddress = null;
                    if (drCus["billingPostalCode"] != DBNull.Value) billingPostalCode = (string)drCus["billingPostalCode"];
                    else billingPostalCode = null;
                    if (drCus["LastModified"] != DBNull.Value) lastModified = (DateTime)drCus["LastModified"];
                    else lastModified = null;

                    users.Add(new Customer(Convert.ToInt32(drCus["id"]), (string)drCus["firstName"], (string)drCus["lastname"], (string)drCus["email"],(byte[])drCus["salt"], (byte[])drCus["password"], phoneNumber, address, postalCode, billingAddress, billingPostalCode, lastModified));
                }
                conn.Close();

                conn.Open();
                string sqlEmp =
                    " select users.Id, firstName, lastName, email, salt, password, phoneNumber, [Address], postalCode, LastModified, [role] from users inner join Employee on Users.Id = Employee.Id order by users.id;";

                SqlCommand cmdEmp = new SqlCommand(sqlEmp, conn);

                SqlDataReader drEmp = cmdEmp.ExecuteReader();

                while (drEmp.Read())
                {
                    string? phoneNumber, address, postalCode;
                    DateTime? lastModified;
                    if (drEmp["phoneNumber"] != DBNull.Value) phoneNumber = (string)drEmp["phoneNumber"];
                    else phoneNumber = null;
                    if (drEmp["address"] != DBNull.Value) address = (string)drEmp["address"];
                    else address = null;
                    if (drEmp["postalCode"] != DBNull.Value) postalCode = (string)drEmp["postalCode"];
                    else postalCode = null;
                    if (drEmp["LastModified"] != DBNull.Value) lastModified = (DateTime)drEmp["LastModified"];
                    else lastModified = null;
                    users.Add(new Employee(Convert.ToInt32(drEmp["id"]), (string)drEmp["firstName"], (string)drEmp["lastName"], (string)drEmp["email"], (byte[])drEmp["salt"], (byte[])drEmp["password"], (string)drEmp["phoneNumber"], (string)drEmp["address"], (string)drEmp["postalCode"], (string)drEmp["role"], lastModified));
                   
                }
                conn.Close();
            }
            return users;
        }


        public byte[] GetSalt(string email) 
        {
            byte[] salt = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql ="select salt from users where email = @email;";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", email);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) 
                {
                   salt = (byte[])dr["salt"];
                }
                conn.Close();
            }
            return salt;
        }

        public string ComaparePassword(string email, byte[] password) 
        {
            string role = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select role from Employee inner join users on employee.id = users.id where users.email = @email AND users.password = @password;";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                   role = (string)dr["role"];
                }
                conn.Close();
                if (role != "") return role;
                conn.Open();
                string sqlCus = "select Customer.Id from Customer inner join Users on Customer.Id = Users.Id where users.email = @email AND users.password = @password;";

                SqlCommand cmdCus = new SqlCommand(sqlCus, conn);
                cmdCus.Parameters.AddWithValue("@email", email);
                cmdCus.Parameters.AddWithValue("@password", password);

                SqlDataReader drCus = cmdCus.ExecuteReader();

                while (drCus.Read())
                {
                    if (Convert.ToInt32(drCus["id"]) != 0) role = "Customer"; break;
                    role = "";
                }
                conn.Close();
            }
            return role;
        }

        public IList<Employee> SearchEmployee(string term, SearchTypeEmployee type)
        {
            IList<Employee> employees = new List<Employee>();
            string query = "";
            int int_search_term;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {


                if (type == SearchTypeEmployee.Role)
                {
                    query = $"select users.Id, firstName, lastName, email, salt, password, phoneNumber, [Address], postalCode, LastModified, [role] from users inner join Employee on Users.Id = Employee.Id WHERE Role = '{term}' ORDER BY id;";

                }
                else
                {
                    query = $"select users.Id, firstName, lastName, email, salt, password, phoneNumber, [Address], postalCode, LastModified, [role] from users inner join Employee on Users.Id = Employee.Id WHERE {type} LIKE '%{term}%' ORDER BY id;";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string? phoneNumber, address, postalCode;
                        DateTime? lastModified;

                        if (dr["phoneNumber"] != DBNull.Value) phoneNumber = (string)dr["phoneNumber"];
                        else phoneNumber = null;
                        if (dr["address"] != DBNull.Value) address = (string)dr["address"];
                        else address = null;
                        if (dr["postalCode"] != DBNull.Value) postalCode = (string)dr["postalCode"];
                        else postalCode = null;
                        if (dr["LastModified"] != DBNull.Value) lastModified = (DateTime)dr["LastModified"];
                        else lastModified = null;

                        employees.Add(new Employee(Convert.ToInt32(dr["id"]), (string)dr["firstName"], (string)dr["lastName"], (string)dr["email"], (byte[])dr["salt"], (byte[])dr["password"], (string)dr["phoneNumber"], (string)dr["address"], (string)dr["postalCode"], (string)dr["role"], lastModified));
                    }
                }
                else
                {
                    throw new Exception("No results found");
                }
                conn.Close();
            }
            return employees;
        }

        public bool UpdateEmployee(Employee newEmployee, Employee currentEmployee)
        {
            bool updated = false;
            if (!CheckIfEmployeeModified(currentEmployee)) throw new ArgumentException("Employee information has been modified while you were changing the information");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "Update Users set firstName = @firstName, lastName = @lastName, email = @email, salt = @salt, password = @password, phoneNumber = @phoneNumber, address = @address, postalCode = @postalCode, LastModified = @LastModified where Users.id = @employeeId; Update Employee set role = @role where Employee.id = @employeeId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@employeeId", currentEmployee.Id);
                cmd.Parameters.AddWithValue("@firstName", newEmployee.FirstName);
                cmd.Parameters.AddWithValue("@lastName", newEmployee.LastName);
                cmd.Parameters.AddWithValue("@email", newEmployee.Email);
                if (Encoding.Default.GetString(newEmployee.Password) == "DoNoTUPdaTePassWord!@#HHGTR")
                {
                    cmd.Parameters.AddWithValue("@salt", currentEmployee.SaltPassword);
                    cmd.Parameters.AddWithValue("@password", currentEmployee.Password);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@salt", newEmployee.SaltPassword);
                    cmd.Parameters.AddWithValue("@password", newEmployee.Password);
                }
                cmd.Parameters.AddWithValue("@phoneNumber", newEmployee.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", newEmployee.Address);
                cmd.Parameters.AddWithValue("@postalCode", newEmployee.PostalCode);
                cmd.Parameters.AddWithValue("@role", newEmployee.Role);
                cmd.Parameters.AddWithValue("@LastModified", DateTime.Now);

                cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() > 0) updated = true;
                conn.Close();
            }
            return updated;
        }

        public bool CheckIfEmployeeModified(Employee currentEmployee)
        {
            bool notModified = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select id from users where (id = @employeeId) AND (lastModified is null OR lastmodified = @lastModifiedCurrent)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@employeeId", currentEmployee.Id);
                if (currentEmployee.LastModified != null) cmd.Parameters.AddWithValue("@lastModifiedCurrent", currentEmployee.LastModified);
                else cmd.Parameters.AddWithValue("@lastModifiedCurrent", DBNull.Value);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if ((int)dr["id"] == currentEmployee.Id) notModified = true;
                }

                conn.Close();
            }
            return notModified;
        }

        public bool DeleteEmployee(Employee employee)
        {
            bool deleted = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "Delete from Users where id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", employee.Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0) return deleted;
                deleted = true;
                conn.Close();
            }
            return deleted;
        }

    }
}
