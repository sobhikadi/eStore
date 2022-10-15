using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntities.Products
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a product name.")]
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool InStock { get { return QuantityInStock > 0; } }
        public int QuantityInStock { get; private set; }
        public double Price { get; private set; }
        public string Category { get; private set; }
        public string SubCategory { get; private set; }
        public string? Isbn { get; private set; }
        public string? SerialNumber { get; private set; }
        public string? Color { get; private set; }
        public string? Platform { get; private set; }

        private List<Review> reviews;
        private Dictionary<string, string> specifications;

        public IList<Review> Reviews { get { return reviews.AsReadOnly(); } }
        public Dictionary<string, string> Specifications { get { return specifications; } }


        public Product(string name, string description, int quantity, double price, string category, string subCategory, string isbn, string serialNumber, string color, string platform)
        {
            Name = name;
            Description = description;
            QuantityInStock = quantity;
            Price = price;
            Category = category;
            SubCategory = subCategory;
            Isbn = isbn;
            SerialNumber = serialNumber;
            Color = color;
            Platform = platform;
            reviews = new List<Review>();
            specifications = new Dictionary<string, string>();
        }

        public Product(int id, string name, string description, int quantity, double price, string category, string subCategory, string? isbn, string? serialNumber, string? color, string? platform)
        {
            Id = id;
            Name = name;
            Description = description;
            QuantityInStock = quantity;
            Price = price;
            Category = category;
            SubCategory = subCategory;
            Isbn = isbn;
            SerialNumber = serialNumber;
            Color = color;
            Platform = platform;
            reviews = new List<Review>();
            specifications = new Dictionary<string, string>();
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

        public bool ChangePrice(double price) 
        {
            Price = price;
            return true;
        }
    }
}
