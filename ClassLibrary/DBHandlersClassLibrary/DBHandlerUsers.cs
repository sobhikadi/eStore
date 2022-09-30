using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using LogicClassLibrary.Products;
using System.Net;
using LogicClassLibrary.Users;
using LogicClassLibrary.User;

namespace LogicClassLibrary.DBHandlersClassLibrary
{
    public class DBHandlerUsers
    {
        private string connectionString = "server=mssqlstud.fhict.local;" + "database=dbi376372;" + "user id=dbi376372;" + "password=Mky3S[elWm;" + "connect timeout=30;";


        public void InsertEmployee(string firstName, string lastName, string email, string password, string phoneNumber, string role, string streetName, string houseNumber, string postalCode)
        {
            string userType = "Employee";
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {

                conn.Open();
                string sql = "insert into Users (firstName, lastName,type, email, password, phoneNumber, role, streetName, houseNumber, postalCode) values (@firstName, @lastName,@type, @email, @password, @phoneNumber, @role, @streetName, @houseNumber, @postalCode);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@type", userType);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@streetName", streetName);
                cmd.Parameters.AddWithValue("@houseNumber", houseNumber);
                cmd.Parameters.AddWithValue("@postalCode", postalCode);

                if (!string.IsNullOrEmpty(role)) { cmd.Parameters.AddWithValue("@role", role); }
                else { cmd.Parameters.AddWithValue("@role", DBNull.Value); }
                

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void InsertCustomer(string firstName, string lastName, string email, string password)
        {
            string userType = "Customer";
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {

                conn.Open();
                string sql = "insert into Users (firstName, lastName,type, email, password) values (@firstName, @lastName,@type, @email, @password);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@type", userType);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<SystemUser> GetAllUsers()
        {
            List<SystemUser> users = new List<SystemUser>();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string sql = "select id, firstName, lastName,type, email, password, phoneNumber, role, streetName, houseNumber, postalCode from users order by id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string type = (string)dr["type"];

                    if (type == "Employee")
                    {
                        users.Add(new Employee(Convert.ToInt32(dr["id"]), (string)dr["firstName"], (string)dr["lastname"], (string)dr["email"], (string)dr["password"], (string)dr["phoneNumber"], (string)dr["streetName"], (string)dr["houseNumber"], (string)dr["postalCode"], (string)dr["role"]));
                    }
                    else if (type == "Customer")
                    {
                        users.Add(new Customer(Convert.ToInt32(dr["id"]), (string)dr["firstName"], (string)dr["lastname"], (string)dr["email"], (string)dr["password"]));
                    }
                }
                conn.Close();
            }
            return users;
        }

    }
}
