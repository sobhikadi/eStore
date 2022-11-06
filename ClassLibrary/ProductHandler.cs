using DataAccessLayer;
using LogicLayerEntities.Products;

namespace LogicLayerHandlers
{
    public class ProductHandler
    {
        private DBHandlerProducts dbHandlerProducts = new DBHandlerProducts();

        private List<Product> products;

        public ProductHandler()
        {
            products = new List<Product>();
            UpdateListOfProducts();
        }

        public IList<Product> Products { get 
            {
                UpdateListOfProducts();
                return products.AsReadOnly(); 
            } }

        public void AddProduct(SingleProduct product)
        {
            if (GetProductName(product)) throw new Exception($"Product with the name {product.Name} already exist in database");
           int id = dbHandlerProducts.InsertProduct(product);
            if (id == 0) throw new Exception("Product has not been added");
            product.Id = id;
            products.Add(product);

            UpdateListOfProducts();
        }

        public void UpdateProduct(SingleProduct newProduct, SingleProduct currentProduct) 
        {
            bool success = dbHandlerProducts.UpdateProduct(newProduct, currentProduct);

            if (!success) throw new ArgumentException("");

            if (!products.Contains(currentProduct)) throw new ArgumentException("");

            currentProduct.ChangeInformation(newProduct);

           UpdateListOfProducts();
        }

        public void AddComboProduct(ComboProduct comboProduct) 
        {
            this.products.Add(comboProduct);
        }

        public IList<Product> SearchProduct(string term, SearchTypeProduct type)
        {
            return dbHandlerProducts.SearchProduct(term, type);
        }

        private bool GetProductName(Product product) 
        {
            foreach (Product prod in products) 
            {
                if (prod.Name == product.Name) return true;
            }
            return false;
        }

        private void UpdateListOfProducts() 
        {
            products.Clear();
            products.AddRange(dbHandlerProducts.GetSingleProducts());
        }

        

    }
}