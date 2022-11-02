using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicLayerEntities.Products
{
    public class Product
    {
        private string name, description, category, subCategory;
        private string? isbn, serialNumber, color, platform;
        private int quantity;
        private double price;


        public int Id { get; private set; }
        public string Name 
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("The field name cannot be empty");
                if (value.Length < 3 || value.Length > 150) throw new ArgumentException("Name must have at least 3 charachters and maximum of 150 charachters");
                name = value;
            }
        }
        public string Description 
        {
            get { return description; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("The field description cannot be empty");
                description = value;
            }
        }
        public bool InStock { get { return QuantityInStock > 0; } }
        public int QuantityInStock 
        {
            get { return quantity; }
            private set
            {
                if(value < 0) throw new ArgumentException("Quantity cannot be less than 0");
                quantity = value;
            }
        }
        public double Price 
        {
            get { return price; }
            private set
            {
                if (value < 0) throw new ArgumentException("Price cannot be less than 0");
                price = value;
            }
        }
        public string Category { get { return category; } private set { category = value; } }
        public string SubCategory 
        {
            get { return subCategory; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Sub category field must be filled");
                if (value.Length < 2 || value.Length > 50) throw new ArgumentException("Sub category must have at least 3 charachters and maximum of 50 charachters");
                subCategory = value;
            }
        }
        public string? Isbn 
        {
            get { return isbn; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.Length < 13 || value.Length > 17) throw new ArgumentException("ISBN must have at least 13 charachters and/or maximum of 17 charachters including the (-)");
                    Regex regex = new Regex("((?:[\\dX]{13})|(?:[\\d\\-X]{17})|(?:[\\dX]{10})|(?:[\\d\\-X]{13}))");
                    if (!regex.IsMatch(value)) throw new ArgumentException("ISBN has been entered in an incorrect format");
                }
                isbn = value;
            }
        }
        public string? SerialNumber 
        {
            get { return serialNumber; }
            private set
            {
                if (value != null)
                {
                    if ( value.Length > 20) throw new ArgumentException("Serial number cannot have more than 17 charachters");
                }
                serialNumber = value;
            }
        }
        public string? Color 
        {
            get { return color; }
            private set
            {
                if (value != null)
                {
                    if (value.Length > 30) throw new ArgumentException("Color cannot have more than 30 charachters");
                }
                color = value;
            }
        }
        public string? Platform 
        {
            get { return color; }
            private set
            {
                if (value != null)
                {
                    if (value.Length > 25) throw new ArgumentException("Color cannot have more than 25 charachters");
                }
                color = value;
            }
        }

        private List<Review> reviews;
        private Dictionary<string, string> specifications;

        public IList<Review> Reviews { get { return reviews.AsReadOnly(); } }
        public Dictionary<string, string> Specifications { get { return specifications; } }


        public Product(string name, string description, int quantity, double price, string category, string subCategory, string? isbn, string? serialNumber, string? color, string? platform)
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
