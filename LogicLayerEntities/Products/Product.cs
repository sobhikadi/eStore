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
        public int Id { get; private set; }

        public Product(string name) 
        {
            Name = name;
        }
        public Product(int id, string name)
        {
            Name = name;
            Id = id;
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
