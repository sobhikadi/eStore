using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary
{
    abstract class Product
    {

        public List<Review> Reviews{ get; set; }
        Dictionary<string, string> Specifications { get; set; }
        
        public Product() 
        {
            Reviews = new List<Review>();
            Specifications = new Dictionary<string, string>();
        }
            

    }
}
