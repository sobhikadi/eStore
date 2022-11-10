using LogicLayerEntities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntities
{
    public class ProductStockComparer : IComparer<SingleProduct>
    {
        public int Compare(SingleProduct one, SingleProduct two)
        {
            return one.QuantityInStock.CompareTo(two.QuantityInStock);
        }
    }
}
