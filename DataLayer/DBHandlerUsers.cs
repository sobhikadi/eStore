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

namespace DataAccessLayer
{
    public class DBHandlerUsers
    {
        private string connectionString = "server=mssqlstud.fhict.local;" + "database=dbi376372;" + "user id=dbi376372;" + "password=Mky3S[elWm;" + "connect timeout=30;";


        public void InsertEmployee(Employee employee)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string sql = "insert into Users (firstName, lastName, email,salt, password, phoneNumber, address, postalCode) values (@firstName, @lastName, @email, @salt, @password, @phoneNumber, @address, @postalCode); select SCOPE_IDENTITY(); insert into Employee (id, role) values (SCOPE_IDENTITY(), @role)";
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

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void InsertCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "insert into Users (firstName, lastName, email, password, phoneNumber, address, postalCode) values (@firstName, @lastName, @email, @password, @phoneNumber, @address, @postalCode); select SCOPE_IDENTITY(); insert into Customer (id, billingAddress, billingPostalCode) values (SCOPE_IDENTITY(), @billingAddress, @billingPostalCode)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@firstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@lastName", customer.LastName);
                cmd.Parameters.AddWithValue("@email", customer.Email);
                cmd.Parameters.AddWithValue("@password", customer.Password);


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

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<Person> GetAllUsers()
        {
            List<Person> users = new List<Person>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sqlCus =
                    " select users.id, firstName, lastName, email, Password, phoneNumber, Address, postalCode, BillingAddress, billingPostalCode from users inner join Customer on users.Id = Customer.Id order by users.id;";

                SqlCommand cmdCus = new SqlCommand(sqlCus, conn);

                SqlDataReader drCus = cmdCus.ExecuteReader();

                while (drCus.Read())
                {
                    string? phoneNumber, address, postalCode, billingAddress, billingPostalCode;

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

                    users.Add(new Customer(Convert.ToInt32(drCus["id"]), (string)drCus["firstName"], (string)drCus["lastname"], (string)drCus["email"], phoneNumber, address, postalCode, billingAddress, billingPostalCode));
                }
                conn.Close();

                conn.Open();
                string sqlEmp =
                    " select users.Id, firstName, lastName, email, [Password], phoneNumber, [Address], postalCode, [role] from users inner join Employee on Users.Id = Employee.Id order by users.id;";

                SqlCommand cmdEmp = new SqlCommand(sqlEmp, conn);

                SqlDataReader drEmp = cmdEmp.ExecuteReader();

                while (drEmp.Read())
                {
                    string? phoneNumber, address, postalCode;

                    if (drEmp["phoneNumber"] != DBNull.Value) phoneNumber = (string)drEmp["phoneNumber"];
                    else phoneNumber = null;
                    if (drEmp["address"] != DBNull.Value) address = (string)drEmp["address"];
                    else address = null;
                    if (drEmp["postalCode"] != DBNull.Value) postalCode = (string)drEmp["postalCode"];
                    else postalCode = null;

                    users.Add(new Employee(Convert.ToInt32(drEmp["id"]), (string)drEmp["firstName"], (string)drEmp["lastName"], (string)drEmp["email"], (string)drEmp["phoneNumber"], (string)drEmp["address"], (string)drEmp["postalCode"], (string)drEmp["role"]));
                   
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
            }
            return role;
        }

    }
}
