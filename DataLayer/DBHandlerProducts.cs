using LogicLayerEntities;
using LogicLayerEntities.Products;
using LogicLayerEntities.Users;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public class DBHandlerProducts
    {

        private string connectionString = "server=mssqlstud.fhict.local;" + "database=dbi376372;" + "user id=dbi376372;" + "password=Mky3S[elWm;" + "connect timeout=30;";


        public void InsertProduct(SingleProduct product)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string sql = "insert into Product (name, quantity, price, category, subcategory, description, isbn, platform, serialNumber, color) values (@name, @quantity, @price, @category, @subCategory, @description, @isbn, @platform, @serialNumber, @color);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@quantity", product.QuantityInStock);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@category", product.Category);
                cmd.Parameters.AddWithValue("@subCategory", product.SubCategory);
                cmd.Parameters.AddWithValue("@description", product.Description);
                if (!string.IsNullOrEmpty(product.Isbn)) cmd.Parameters.AddWithValue("@isbn", product.Isbn);
                else cmd.Parameters.AddWithValue("@isbn", DBNull.Value);
                if (!string.IsNullOrEmpty(product.Platform)) cmd.Parameters.AddWithValue("@platform", product.Platform);
                else cmd.Parameters.AddWithValue("@platform", DBNull.Value);
                if (!string.IsNullOrEmpty(product.SerialNumber)) { cmd.Parameters.AddWithValue("@serialNumber", product.SerialNumber); }
                else cmd.Parameters.AddWithValue("@serialNumber", DBNull.Value);
                if (!string.IsNullOrEmpty(product.Color)) cmd.Parameters.AddWithValue("@color", product.Color);
                else cmd.Parameters.AddWithValue("@color", DBNull.Value);

                cmd.ExecuteNonQuery();

                conn.Close();
            }

        }

        public List<SingleProduct> GetAllProducts()
        {
            List<SingleProduct> products = new List<SingleProduct>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select id, name, quantity, price, category, subcategory, description, isbn, platform, serialNumber, color from product order by id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string? isbn, serialNumber, color, platform;

                    if (dr["isbn"] != DBNull.Value) isbn = (string)dr["isbn"];
                    else isbn = null;
                    if (dr["serialNumber"] != DBNull.Value) serialNumber = (string)dr["serialNumber"];
                    else serialNumber = null;
                    if (dr["color"] != DBNull.Value) color = (string)dr["color"];
                    else color = null;
                    if (dr["platform"] != DBNull.Value) platform = (string)dr["platform"];
                    else platform = null;

                    products.Add(new SingleProduct(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["description"], Convert.ToInt32(dr["quantity"]), Convert.ToDouble(dr["price"]), (string)dr["category"], (string)dr["subCategory"], isbn, serialNumber, color, platform));
                }
                conn.Close();
            }
            return products;
        }

        //public static IList<Product> SearchProduct(string term, SearchTypeProduct type)
        //{
        //    IList<Animal> animals = new List<Animal>();
        //    string query;
        //    int int_search_term;
        //    if (type == SearchTypeAnimal.Type)
        //    {
        //        query = $"SELECT id, nickname, species, type, gender, alive, date_of_birth, date_of_entry, location FROM Animal WHERE {type.ToString().ToLower()} = {(int)(AnimalType)Enum.Parse(typeof(AnimalType), term)} ORDER BY id;";

        //    }
        //    else if (type == SearchTypeAnimal.Gender)
        //    {
        //        query = $"SELECT id, nickname, species, type, gender, alive, date_of_birth, date_of_entry, location FROM Animal WHERE {type.ToString().ToLower()} = {(int)(AnimalGender)Enum.Parse(typeof(AnimalGender), term)} ORDER BY id;";

        //    }
        //    else
        //    {
        //        query = $"SELECT id, nickname, species, type, gender, alive, date_of_birth, date_of_entry, location FROM Animal WHERE LOWER({type.ToString()}) LIKE '%{term}%' ORDER BY id;";
        //    }
        //    using (SqlConnection conn = new SqlConnection(adress))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            conn.Open();
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {
        //                    int id = reader.GetInt32(0);
        //                    string nickName = reader.GetString(1);
        //                    string species = reader.GetString(2);
        //                    int typ = reader.GetInt32(3);
        //                    int gender = reader.GetInt32(4);
        //                    bool alive = reader.GetBoolean(5);
        //                    DateTime dateOfBirth = reader.GetDateTime(6);
        //                    DateTime dateOfEntry = reader.GetDateTime(7);
        //                    string location = reader.GetString(8);
        //                    animals.Add(new(id, nickName, species, typ, gender, alive, dateOfBirth, dateOfEntry, location));
        //                }
        //            }
        //            else
        //            {
        //                throw new Exception("No results found");
        //            }
        //        }
        //    }
        //    return animals;
        //}

        

    }
}