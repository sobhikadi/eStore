using LogicLayerEntities;
using LogicLayerEntities.Products;
using LogicLayerEntities.Users;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class DBHandlerProducts
    {

        private string connectionString = "server=mssqlstud.fhict.local;" + "database=dbi376372;" + "user id=dbi376372;" + "password=Mky3S[elWm;" + "connect timeout=30;";


        public int InsertProduct(SingleProduct product)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "insert into Product (name, quantity, price, category, subcategory, description, isbn, platform, serialNumber, color, Image, lastModified) values (@name, @quantity, @price, @category, @subCategory, @description, @isbn, @platform, @serialNumber, @color, @image, @lastModified); select SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@quantity", product.QuantityInStock);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@category", product.Category);
                cmd.Parameters.AddWithValue("@subCategory", product.SubCategory);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@lastModified", DBNull.Value);

                if (!string.IsNullOrEmpty(product.Isbn)) cmd.Parameters.AddWithValue("@isbn", product.Isbn);
                else cmd.Parameters.AddWithValue("@isbn", DBNull.Value);
                if (!string.IsNullOrEmpty(product.Platform)) cmd.Parameters.AddWithValue("@platform", product.Platform);
                else cmd.Parameters.AddWithValue("@platform", DBNull.Value);
                if (!string.IsNullOrEmpty(product.SerialNumber)) { cmd.Parameters.AddWithValue("@serialNumber", product.SerialNumber); }
                else cmd.Parameters.AddWithValue("@serialNumber", DBNull.Value);
                if (!string.IsNullOrEmpty(product.Color)) cmd.Parameters.AddWithValue("@color", product.Color);
                else cmd.Parameters.AddWithValue("@color", DBNull.Value);
                if (product.Image != null) cmd.Parameters.AddWithValue("@image", product.Image);
                else cmd.Parameters.Add("@image", SqlDbType.VarBinary).Value = DBNull.Value;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) id = Convert.ToInt32(dr[0]);

                conn.Close();
            }
            return id;
        }

        public List<SingleProduct> GetSingleProducts()
        {
            List<SingleProduct> products = new List<SingleProduct>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select id, name, quantity, price, category, subcategory, description, isbn, platform, serialNumber, color, image, lastModified from product order by id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string? isbn, serialNumber, color, platform;
                    byte[]? image;
                    DateTime? lastModified;

                    if (dr["isbn"] != DBNull.Value) isbn = (string)dr["isbn"];
                    else isbn = null;
                    if (dr["serialNumber"] != DBNull.Value) serialNumber = (string)dr["serialNumber"];
                    else serialNumber = null;
                    if (dr["color"] != DBNull.Value) color = (string)dr["color"];
                    else color = null;
                    if (dr["platform"] != DBNull.Value) platform = (string)dr["platform"];
                    else platform = null;
                    if (dr["image"] != DBNull.Value) image = (byte[])dr["image"];
                    else image = null;
                    if (dr["lastModified"] != DBNull.Value) lastModified = (DateTime)dr["lastModified"];
                    else lastModified = null;

                    products.Add(new SingleProduct(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["description"], Convert.ToInt32(dr["quantity"]), Convert.ToDouble(dr["price"]), (string)dr["category"], (string)dr["subCategory"], isbn, serialNumber, color, platform, image, lastModified));
                }
                conn.Close();
            }
            return products;
        }

        public bool UpdateProduct(SingleProduct newProduct, SingleProduct currentProduct) 
        {
            if(!CheckIfProductModified(currentProduct)) throw new ArgumentException("Product has been modified while you were changing the information");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "Update Product set name = @name, quantity = @quantity, price = @price, category = @category, subcategory = @subCategory, description = @description, isbn = @isbn, platform = @platform, serialNumber = @serialNumber, color = @color, Image = @image, lastModified = @lastModified where product.id = @productId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@productId", currentProduct.Id);
                cmd.Parameters.AddWithValue("@name", newProduct.Name);
                cmd.Parameters.AddWithValue("@quantity", newProduct.QuantityInStock);
                cmd.Parameters.AddWithValue("@price", newProduct.Price);
                cmd.Parameters.AddWithValue("@category", newProduct.Category);
                cmd.Parameters.AddWithValue("@subCategory", newProduct.SubCategory);
                cmd.Parameters.AddWithValue("@description", newProduct.Description);
                cmd.Parameters.AddWithValue("@lastModified", DateTime.Now);
                if (!string.IsNullOrEmpty(newProduct.Isbn)) cmd.Parameters.AddWithValue("@isbn", newProduct.Isbn);
                else cmd.Parameters.AddWithValue("@isbn", DBNull.Value);
                if (!string.IsNullOrEmpty(newProduct.Platform)) cmd.Parameters.AddWithValue("@platform", newProduct.Platform);
                else cmd.Parameters.AddWithValue("@platform", DBNull.Value);
                if (!string.IsNullOrEmpty(newProduct.SerialNumber)) { cmd.Parameters.AddWithValue("@serialNumber", newProduct.SerialNumber); }
                else cmd.Parameters.AddWithValue("@serialNumber", DBNull.Value);
                if (!string.IsNullOrEmpty(newProduct.Color)) cmd.Parameters.AddWithValue("@color", newProduct.Color);
                else cmd.Parameters.AddWithValue("@color", DBNull.Value);
                if (newProduct.Image != null) cmd.Parameters.AddWithValue("@image", newProduct.Image);
                else cmd.Parameters.Add("@image", SqlDbType.VarBinary).Value = DBNull.Value;

                cmd.ExecuteNonQuery();                

                conn.Close();
            }
            return true;
        }

        public IList<Product> SearchProduct(string term, SearchTypeProduct type)
        {
            IList<Product> products = new List<Product>();
            string query = "";
            int int_search_term;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                

                if (type == SearchTypeProduct.Category)
                {
                    query = $"select id, name, quantity, price, category, subcategory, description, isbn, platform, serialNumber, color, image, lastmodified from product WHERE category = '{term}' ORDER BY id;";
                    
                }
                else
                {
                    query = $"select id, name, quantity, price, category, subcategory, description, isbn, platform, serialNumber, color, image, lastmodified from product WHERE {type} LIKE '%{term}%' ORDER BY id;";
                    

                }

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string? isbn, serialNumber, color, platform;
                        byte[]? image;
                        DateTime? lastModified;

                        if (dr["isbn"] != DBNull.Value) isbn = (string)dr["isbn"];
                        else isbn = null;
                        if (dr["serialNumber"] != DBNull.Value) serialNumber = (string)dr["serialNumber"];
                        else serialNumber = null;
                        if (dr["color"] != DBNull.Value) color = (string)dr["color"];
                        else color = null;
                        if (dr["platform"] != DBNull.Value) platform = (string)dr["platform"];
                        else platform = null;
                        if (dr["image"] != DBNull.Value) image = (byte[])dr["image"];
                        else image = null;
                        if (dr["lastModified"] != DBNull.Value) lastModified = (DateTime)dr["lastModified"];
                        else lastModified = null;

                        products.Add(new SingleProduct(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["description"], Convert.ToInt32(dr["quantity"]), Convert.ToDouble(dr["price"]), (string)dr["category"], (string)dr["subCategory"], isbn, serialNumber, color, platform, image, lastModified));
                    }
                }
                else
                {
                    throw new Exception("No results found");
                }
                conn.Close();
            }
            return products;
        }

        private bool CheckIfProductModified(SingleProduct currentProduct)
        {
            bool modified = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select id from Product where (product.id = @productId) AND (lastModified is null OR lastmodified = @lastModifiedCurrent)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@productId", currentProduct.Id);
                if (currentProduct.LastModified != null) cmd.Parameters.AddWithValue("@lastModifiedCurrent", currentProduct.LastModified);
                else cmd.Parameters.AddWithValue("@lastModifiedCurrent", DBNull.Value);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if ((int)dr["id"] == currentProduct.Id) modified = true;
                }

                conn.Close();
            }
            return modified;
        }

    }
}