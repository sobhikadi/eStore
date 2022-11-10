using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntities.Products
{
    public abstract class Product
    {
        private string name;
        private DateTime? lastModified;
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
        public int Id { get; set; }
        public DateTime? LastModified { get { return lastModified; } set { lastModified = value; } }

        public Product(string name, DateTime? lastModified) 
        {
            Name = name;
            LastModified = lastModified;
        }
        public Product(int id, string name, DateTime? lastModified)
        {
            Name = name;
            Id = id;
            LastModified = lastModified;
        }

        public void ChangeName(string name) 
        {
            Name = name.Trim();
        }

        public abstract bool InStock();
        public abstract double GetPrice();
        public abstract int GetQuantity();

        

    }
}
