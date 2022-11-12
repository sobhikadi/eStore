using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LogicLayerEntities.Products
{
    public class SingleProduct : Product, IComparable<SingleProduct>
    {
        private string description, category, subCategory;
        private string? isbn, serialNumber, color, platform;
        private int quantity;
        private double price;
        private byte[]? image;

        public string Description 
        {
            get { return description; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("The field description cannot be empty");
                description = value;
            }
        }
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
            get { return platform; }
            private set
            {
                if (value != null)
                {
                    if (value.Length > 25) throw new ArgumentException("Platform cannot have more than 25 charachters");
                }
                platform = value;
            }
        }
        public byte[]? Image { get { return image; } set { image = value; } }

        private List<Review> reviews;
        private Dictionary<string, string> specifications;

        public IList<Review> Reviews { get { return reviews.AsReadOnly(); } }
        public Dictionary<string, string> Specifications { get { return specifications; } }


        public SingleProduct(string name, string description, int quantity, double price, string category, string subCategory, string? isbn, string? serialNumber, string? color, string? platform, byte[]? image, DateTime? lastModified) : base(name, lastModified)
        {
            Description = description;
            QuantityInStock = quantity;
            Price = price;
            Category = category;
            SubCategory = subCategory;
            Isbn = isbn;
            SerialNumber = serialNumber;
            Color = color;
            Platform = platform;
            Image = image;
            reviews = new List<Review>();
            specifications = new Dictionary<string, string>();
        }

        public SingleProduct(int id, string name, string description, int quantity, double price, string category, string subCategory, string? isbn, string? serialNumber, string? color, string? platform, byte[]? image, DateTime? lastModified) : base(id, name, lastModified)
        {
            Description = description;
            QuantityInStock = quantity;
            Price = price;
            Category = category;
            SubCategory = subCategory;
            Isbn = isbn;
            SerialNumber = serialNumber;
            Color = color;
            Platform = platform;
            Image = image;
            reviews = new List<Review>();
            specifications = new Dictionary<string, string>();
        }

        public void ChangeInformation(SingleProduct product) 
        {
            product.ChangeName(product.Name);
            Description = product.Description;
            QuantityInStock = product.QuantityInStock;
            Price = product.Price;
            Category = product.Category;
            SubCategory = product.subCategory;
            Isbn = product.Isbn;
            SerialNumber = product.SerialNumber;
            Color = product.Color;
            Platform = product.Platform;
            Image = product.Image;

        }

        public override double GetPrice()
        {
            return Price;
        }

        public override int GetQuantity()
        {
            return QuantityInStock;
        }

        public int CompareTo(SingleProduct anotherProduct)
        {
            return this.QuantityInStock.CompareTo(anotherProduct.QuantityInStock);
        }

        public override bool InStock()
        {
            return QuantityInStock > 0;
        }

        public bool AddSpecifications(string name, string value)
        {

            foreach (KeyValuePair<string, string> kvp in specifications) 
            {
                if (kvp.Key == name) throw new ArgumentException($"Specfications with the name ({name}) already exists");
            }
            specifications.Add(name, value);
            return true;
        }

        public void GetSpecsFromDB(Dictionary<string, string> specs) 
        {
            specifications.Clear();
            specifications = specs;
        }

        


    }
}
