using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary
{
    internal class Electronics : Product, IProductInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool InStock { get; set; }
        public int QuantityInStock { get; set; }
        public double Price { get; set; }
        public string SubCategory { get; set; }

        public string SerialNumber{ get; set; }

        public string Color { get; set; }

        public Electronics(int id, string name, string description, int quantity, double price, string subCategory, string serialNumber, string color) : base()
        {
            Id = id;
            Name = name;
            Description = description;
            InStock = false;
            QuantityInStock = quantity;
            Price = price;
            SubCategory = subCategory;
            SerialNumber = serialNumber;
            Color = color;
        }
    }
}
