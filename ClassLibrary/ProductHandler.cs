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

        public void AddProduct(Product product)
        {
            int id = dbHandlerProducts.InsertProduct(product);
            product.Id = id;
            products.Add(product);
        }
    }
}