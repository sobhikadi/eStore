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


        public void InsertProduct(Product product)
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
                    string? isbn, serialNumber, color, platform;

                    if (dr["isbn"] != DBNull.Value) isbn = (string)dr["isbn"];
                    else isbn = null;
                    if (dr["serialNumber"] != DBNull.Value) serialNumber = (string)dr["serialNumber"];
                    else serialNumber = null;
                    if (dr["color"] != DBNull.Value) color = (string)dr["color"];
                    else color = null;
                    if (dr["platform"] != DBNull.Value) platform = (string)dr["platform"];
                    else platform = null;

                    products.Add(new Product(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["description"], Convert.ToInt32(dr["quantity"]), Convert.ToDouble(dr["price"]), (string)dr["category"], (string)dr["subCategory"], isbn, serialNumber, color, platform));
                }
                conn.Close();
            }
            return products;
        }

    }
}