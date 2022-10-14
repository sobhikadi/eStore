using DataAccessLayer;
using LogicLayerEntities.Products;

namespace LogicLayerHandlers
{
    public class ProductHandler
    {
        private DBHandlerProducts dbHandlerProducts = new DBHandlerProducts();
        private List<Product> products;
        public IList<Product> Products { get { return products.AsReadOnly(); } }

        public ProductHandler()
        {
            products = new List<Product>();
            products = dbHandlerProducts.GetAllProducts();
        }

        public void AddProduct(string name, int quantity, double price, string category, string subCategory, string description, string isbn, string platform, string serialNumber, string color)
        {
            dbHandlerProducts.InsertProduct(name, quantity, price, category, subCategory, description, isbn, platform, serialNumber, color);

            products = dbHandlerProducts.GetAllProducts();
        }
    }
}