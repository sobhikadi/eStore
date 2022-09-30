using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Products
{
    public class Electronics : Product
    {
        public string SubCategory { get; private set; }
        public string SerialNumber { get; private set; }
        public string Color { get; private set; }

        public Electronics(int id, string name, string description, int quantity, double price, string subCategory, string serialNumber, string color) : base(id, name, description, quantity, price)
        {
            SubCategory = subCategory;
            SerialNumber = serialNumber;
            Color = color;
        }
    }
}
