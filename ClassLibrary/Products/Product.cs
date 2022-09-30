using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Products
{
    public abstract class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool InStock { get; private set; }
        public int QuantityInStock { get; private set; }
        public double Price { get; private set; }

        private List<Review> reviews;
        private List<Specification> specifications;

        public IList<Review> Reviews { get { return reviews.AsReadOnly(); } }
        public List<Specification> Specifications { get { return specifications; } }


        public Product(string name, string description, int quantity, double price)
        {

            Name = name;
            Description = description;
            QuantityInStock = quantity;
            Price = price;
            reviews = new List<Review>();
            specifications = new List<Specification>();
        }

        public Product(int id, string name, string description, int quantity, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            QuantityInStock = quantity;
            Price = price;
            reviews = new List<Review>();
            specifications = new List<Specification>();
        }

        public void ChangeName(string name)
        {
            Name = name.Trim();
        }

        public void ChangeDescription(string description)
        {
            Description = description.Trim();
        }

        public void IncreaseStock(int amount)
        {
            QuantityInStock += amount;
        }

        public bool DecreaseStock(int amount)
        {
            if (QuantityInStock - amount < 0)
            {
                return false;
            }
            QuantityInStock -= amount;
            return true;
        }
    }
}
