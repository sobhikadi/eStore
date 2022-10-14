using LogicLayerEntities;
using LogicLayerEntities.Products;
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


        public void InsertProduct(string name, int quantity, double price, string category, string subCategory, string description, string? isbn, string? platform, string? serialNumber, string? color)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string sql = "insert into Product (name, quantity, price, category, subcategory, description, isbn, platform, serialNumber, color) values (@name, @quantity, @price, @category, @subCategory, @description, @isbn, @platform, @serialNumber, @color);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@subCategory", subCategory);
                cmd.Parameters.AddWithValue("@description", description);
                if (!string.IsNullOrEmpty(isbn)) { cmd.Parameters.AddWithValue("@isbn", isbn); }
                else { cmd.Parameters.AddWithValue("@isbn", DBNull.Value); }
                if (!string.IsNullOrEmpty(platform)) { cmd.Parameters.AddWithValue("@platform", platform); }
                else { cmd.Parameters.AddWithValue("@platform", DBNull.Value); }
                if (!string.IsNullOrEmpty(serialNumber)) { cmd.Parameters.AddWithValue("@serialNumber", serialNumber); }
                else { cmd.Parameters.AddWithValue("@serialNumber", DBNull.Value); }
                if (!string.IsNullOrEmpty(color)) { cmd.Parameters.AddWithValue("@color", color); }
                else { cmd.Parameters.AddWithValue("@color", DBNull.Value); }

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select id, name, quantity, price, category, subcategory, description, isbn, platform, serialNumber, color from product order by id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string category = (string)dr["category"];

                    if (category == Categories.Books.ToString())
                    {
                        products.Add(new Books(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["description"], Convert.ToInt32(dr["quantity"]), Convert.ToDouble(dr["price"]), (string)dr["subCategory"], (string)dr["isbn"]));
                    }
                    else if (category == Categories.Electronics.ToString())
                    {
                        products.Add(new Electronics(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["description"], Convert.ToInt32(dr["quantity"]), Convert.ToDouble(dr["price"]), (string)dr["subCategory"], (string)dr["serialNumber"], (string)dr["color"]));
                    }
                    else if (category == Categories.VedioGames.ToString())
                    {
                        products.Add(new VedioGames(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["description"], Convert.ToInt32(dr["quantity"]), Convert.ToDouble(dr["price"]), (string)dr["platform"]));
                    }
                    else if (category == Categories.Households.ToString())
                    {
                        products.Add(new Households(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["description"], Convert.ToInt32(dr["quantity"]), Convert.ToDouble(dr["price"]), (string)dr["subCategory"], (string)dr["color"]));
                    }

                }
                conn.Close();
            }
            return products;
        }






    }
}