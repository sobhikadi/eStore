using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntities.Products
{
    public class Specification
    {
        public string SpecsKey { get; private set; }
        public string SpecsValue { get; private set; }

        public Specification(string key, string value) 
        {
            SpecsKey = key;
            SpecsValue = value;
        }

        public override string ToString()
        {
            return $"{SpecsKey} - {SpecsValue}";
        }
    }
}
