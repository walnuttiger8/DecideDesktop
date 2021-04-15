using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecideDesktop.Classes
{
    internal class Trade
    {
        internal Wallet Wallet { get; set; } 
        internal float Price { get; set; }
        internal float Amount { get; set; }
        internal string Time { get; set; }
        internal string Transaction { get; set; }

        public Trade(Wallet wallet, float price, float amount, string time, string type)
        {
            this.Wallet = wallet;
            this.Price = price;
            this.Amount = amount;
            this.Time = time;
            this.Transaction = type;
        }

        internal static Trade FromJson(Dictionary<string, object> JsonResult)
        {
            Wallet wallet = Wallet.FromJson((Dictionary<string, object>)JsonResult["wallet"]);

            return new Trade(wallet, float.Parse(JsonResult["price"].ToString()), float.Parse(JsonResult["amount"].ToString()), JsonResult["time"].ToString(), JsonResult["transaction"].ToString());
        }
    }
}
