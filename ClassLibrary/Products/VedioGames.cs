using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Products
{
    public class VedioGames : Product
    {
        public string Platform { get; private set; }

        public VedioGames(int id, string name, string description, int quantity, double price, string platform) : base(id, name, description, quantity, price)
        {
            Platform = platform;
        }
    }
}
