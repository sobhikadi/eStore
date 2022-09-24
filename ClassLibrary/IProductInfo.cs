using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary
{
    internal interface IProductInfo
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        bool InStock { get; set; }
        int QuantityInStock { get; set; }
        double Price { get; set; }
        string SubCategory { get; set; }
    }
}
