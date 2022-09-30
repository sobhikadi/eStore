using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Products
{
    public class Books : Product
    {

        public string SubCategory { get; private set; }

        public string Isbn { get; private set; }

        public Books(int id, string name, string description, int quantity, double price, string subCategory, string isbn) : base(id, name, description, quantity, price)
        {
            SubCategory = subCategory;
            Isbn = isbn;
        }
    }

}
