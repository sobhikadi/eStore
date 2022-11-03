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


        public ComboProduct(string name, List<SingleProduct> products, double discount) : base(name)
        {
            this.products = new List<SingleProduct>();
            this.products = products;
            Discount = discount;
        }
        public ComboProduct(int id, string name, List<SingleProduct> products, double discount, int quantity) : base(id, name)
        {
            this.products = new List<SingleProduct>();
            this.products = products;
            Discount = discount;
        }

        public IList<SingleProduct> Products { get { return products.AsReadOnly(); } }

        public override double GetPrice()
        {  
            return ((products.Sum(p => p.Price) / 100) - Discount) * 100;
        }

        public override int GetQuantity()
        {
            SortByQuantity();
            return products[-1].GetQuantity();
        }

        public void SortByQuantity()
        {
            // Ensure creation of at most one instance
            if (this.productStockComparer == null)
                this.productStockComparer = new ProductStockComparer();

            this.products.Sort(this.productStockComparer);
        }

        public override bool InStock()
        {
            return GetQuantity() > 0;
        }
    }
}
