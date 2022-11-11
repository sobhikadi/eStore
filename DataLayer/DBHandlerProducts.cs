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
    public class DBHandlerProducts : IDBMediatorProduct
    {

        private string connectionString = "server=mssqlstud.fhict.local;" + "database=dbi376372;" + "user id=dbi376372;" + "password=Mky3S[elWm;" + "connect timeout=30;";


        public int InsertProduct(SingleProduct product)
        {
            if (CheckIfProductExist(product.Name)) throw new ArgumentException("Product already exist");
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

                    SingleProduct product = new SingleProduct(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["description"], Convert.ToInt32(dr["quantity"]), Convert.ToDouble(dr["price"]), (string)dr["category"], (string)dr["subCategory"], isbn, serialNumber, color, platform, image, lastModified);

                    product.GetSpecsFromDB(GetProductSpecifications(Convert.ToInt32(dr["id"])));

                    products.Add(product);
                }
                conn.Close();
            }
            return products;
        }

        public List<ComboProduct> GetComboProducts()
        {
            ComboProduct product = null;
            List<ComboProduct> comboProducts = new List<ComboProduct>();

            int idCombo = 0;
            string name = "";
            double discount = 0;
            List<SingleProduct> singleInCombo = new List<SingleProduct>();
            DateTime? lastModified = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select  id , name, discount, lastModified from ComboProduct order by ComboProduct.id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    idCombo = Convert.ToInt32(dr["id"]);
                    name = (string)dr["name"];
                    discount = Convert.ToDouble(dr["discount"]);
                    if (dr["lastModified"] != DBNull.Value) lastModified = (DateTime)dr["lastModified"];
                    else lastModified = null;
                    product = new ComboProduct(idCombo, name, singleInCombo, discount, lastModified);
                    comboProducts.Add(product);
                }
                conn.Close();
                foreach (ComboProduct produ in comboProducts)
                {
                    using (SqlConnection connSub = new SqlConnection(connectionString))
                    {
                        connSub.Open();
                        string sqlSub = "select id from SingleProductInCombo where comboId = @comboId order by id;";
                        SqlCommand cmdSub = new SqlCommand(sqlSub, connSub);
                        cmdSub.Parameters.AddWithValue("comboId", produ.Id);

                        SqlDataReader drSub = cmdSub.ExecuteReader();
                        singleInCombo.Clear();
                        while (drSub.Read())
                        {
                            int singleId = Convert.ToInt32(drSub["id"]);

                            singleInCombo.AddRange(SearchProduct(singleId.ToString(), SearchTypeProduct.Id));
                        }
                        produ.Products = singleInCombo;
                        connSub.Close();
                    }
                }
            }

            
            return comboProducts;
        }

        public bool UpdateProduct(SingleProduct newProduct, SingleProduct currentProduct) 
        {
            bool update = false;
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
                if (cmd.ExecuteNonQuery() > 0) update = true;
                conn.Close();
            }
            return update;
        }

        public List<SingleProduct> SearchProduct(string term, SearchTypeProduct type)
        {
            List<SingleProduct> products = new List<SingleProduct>();
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

        public bool CheckIfProductModified(SingleProduct currentProduct)
        {
            bool notModified = false;
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
                    if ((int)dr["id"] == currentProduct.Id) notModified = true;
                }

                conn.Close();
            }
            return notModified;
        }

        public bool DeleteProduct(SingleProduct product) 
        {
            bool deleted = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "Delete from Product where id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", product.Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0) return deleted;
                deleted = true;
                conn.Close();
            }
            return deleted;
        }

        public bool AddSpecification(SingleProduct product, string name, string value) 
        {
            bool added = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "insert into ProductSpecification(SpecsName, SpecsValue, ProductId) values(@SpecsName, @SepcsValue, @ProductId)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SpecsName", name);
                cmd.Parameters.AddWithValue("@SepcsValue", value);
                cmd.Parameters.AddWithValue("@ProductId", product.Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0) return added;
                added = true;
                conn.Close();
            }
            return added;
        }

        public Dictionary<string, string> GetProductSpecifications(int  productId) 
        {
            Dictionary<string, string> specifications = new Dictionary<string, string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select SpecsName, SpecsValue from ProductSpecification where ProductId = @productId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductId", productId);

                SqlDataReader dr = cmd.ExecuteReader(); 

                if (!dr.HasRows) return specifications;
                while (dr.Read()) 
                {
                    specifications.Add((string)dr["SpecsName"], (string)dr["SpecsValue"]);
                }
                conn.Close();
            }
            return specifications;
        }

        public bool DeleteSpecFromDB(int productId, string specName)
        {
            bool deleted = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "Delete from ProductSpecification where ProductId = @id AND SpecsName = @specName";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", productId);
                cmd.Parameters.AddWithValue("@specName", specName);


                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0) return deleted;
                deleted = true;
                conn.Close();
            }
            return deleted;
        }

        public bool CheckIfProductExist(string name) 
        {
            bool exist = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select id from Product where name=@name";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", name);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    exist = true;
                }

                conn.Close();
            }
            return exist;
        }

        public int InsertComboProduct(ComboProduct comboProduct)
        {
            if (CheckIfProductExist(comboProduct.Name)) throw new ArgumentException("Product already exist");
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "insert into ComboProduct (name, discount, LastModified) values (@name, @discount, @lastModified); select SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", comboProduct.Name);
                cmd.Parameters.AddWithValue("@discount", comboProduct.Discount);
                cmd.Parameters.AddWithValue("@lastModified", DBNull.Value);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) id = Convert.ToInt32(dr[0]);
                conn.Close();
            }
            if (id != 0) 
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (SingleProduct prod in comboProduct.Products)
                    {
                        string sql = "insert into SingleProductInCombo (id, ComboId) values (@SingleId, @ComboId);";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@SingleId", prod.Id);
                        cmd.Parameters.AddWithValue("@ComboId", id);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            return id;
        }

    }
}