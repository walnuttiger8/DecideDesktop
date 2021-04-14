using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecideDesktop.Classes
{
    internal class Coin
    {
        internal string Symbol { get; set; }
        internal float Price { get; set; }

        public Coin(string Symbol, float Price)
        {
            this.Symbol = Symbol;
            this.Price = Price;
        }
    }
}
