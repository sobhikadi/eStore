using DataClassLibrary;

namespace LogicClassLibrary
{
    public class ProductHandler
    {
        private List<Product> products;

        public ProductHandler() 
        {
            products = new List<Product>();
        }

        public void AddProduct(string name, int quantity, double price, string category, string subCategory, string description, string isbn, string platform, string serialNumber, string color) 
        {
            if (category == Categories.Books.ToString())
            {
                products.Add(new Books(0, name, description, quantity, price, subCategory, isbn));
            }
            else if (category == Categories.Electronics.ToString()) 
            {
                products.Add(new Electronics(0, name, description, quantity, price, subCategory, serialNumber, color));
            }


        }

    }
}