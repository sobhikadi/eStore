using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntities.Products
{
    public class ComboProduct : Product
    {
        private ProductStockComparer productStockComparer;
        private List<SingleProduct> products;
        private double discount;

        public double Discount { get { return discount; } private set { discount = value; } }


        public ComboProduct(string name, List<SingleProduct> products, double discount, DateTime? lastModified) : base(name, lastModified)
        {
            this.products = new List<SingleProduct>();
            Products = products;
            Discount = discount;
        }
        public ComboProduct(int id, string name, List<SingleProduct> products, double discount, int quantity, DateTime? lastModified) : base(id, name, lastModified)
        {
            this.products = new List<SingleProduct>();
            Products = products;
            Discount = discount;
        }

        public List<SingleProduct> Products { get { return products; } 
            private set 
            {
                if (value.Count == 0) throw new ArgumentException("ComboProduct must at least have one product");
                if (value.Count > 5) throw new ArgumentException("ComboProduct can have at max 5 products");
                products = value;
            }
        }

        public override double GetPrice()
        {
            double sum = (products.Sum(p => p.Price) * Discount);
            return products.Sum(p => p.Price) - sum;
        }

        public override int GetQuantity()
        {
            SortByQuantity();
            return products[0].GetQuantity();
        }

        public void SortByQuantity()
        {
            // Ensure creation of at most one instance
            if (this.productStockComparer == null) this.productStockComparer = new ProductStockComparer();

            this.products.Sort(this.productStockComparer);
        }

        public override bool InStock()
        {
            return GetQuantity() > 0;
        }
    }
}
