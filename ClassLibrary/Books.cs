using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary
{
    internal class Books : Product, IProductInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool InStock { get; set; }
        public int QuantityInStock { get; set; }
        public double Price { get; set; }
        public string SubCategory { get; set; }

        public string Isbn{ get; set; }

        public Books(int id, string name, string description, int quantity, double price, string subCategory, string isbn ) : base()
        {
            Id = id;
            Name = name;
            Description = description;
            QuantityInStock = quantity;
            Price = price;
            SubCategory = subCategory;
            Isbn = isbn;
        }

    }

}
