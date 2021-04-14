using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecideDesktop.Classes
{
    internal class Wallet
    {
        internal Coin Coin { get; set; }
        internal float Amount { get; set; }
        internal float Percent { get; set; }

        public Wallet(Coin Coin, float Amount, float Percent)
        {
            this.Coin = Coin;
            this.Amount = Amount;
            this.Percent = Percent;
        }
    }
}
