using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntities.Products
{
    public class ComboProduct
    {
        private List<Product> products;
        private double price;
        private int quantity;
        private string name;

        public int Id { get; private set; }
        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } private set { price = value; } }
        public int Quantity { get { return quantity; } private set { quantity = value; } }

        public ComboProduct(string name, List<Product> products, double discount, int quantity) 
        {
            Name = name;
            this.products = new List<Product>();
            this.products = products;
            Price = (((products.Sum(p => p.Price) / 100) - discount) * 100);
            Quantity = quantity;
        }
        public ComboProduct(int id, string name, List<Product> products, double discount, int quantity)
        {
            Id = id;
            Name = name;
            this.products = new List<Product>();
            this.products = products;
            Price = (((products.Sum(p => p.Price) / 100) - discount) * 100);
            Quantity = quantity;
        }

        public IList<Product> Products { get { return products.AsReadOnly(); } }


      
    }
}
