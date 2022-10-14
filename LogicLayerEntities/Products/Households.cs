using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntities.Products
{
    public class Households : Product
    {
        public string SubCategory { get; private set; }

        public string Color { get; private set; }

        public Households(int id, string name, string description, int quantity, double price, string subCategory, string color) : base(id, name, description, quantity, price)
        {
            SubCategory = subCategory;
            Color = color;
        }
    }
}
