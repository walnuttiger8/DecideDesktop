using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecideDesktop.Classes
{
    internal class Trade
    {
        internal string Symbol { get; set; }
        internal float Price { get; set; }
        internal float Amount { get; set; }
        internal string Time { get; set; }
        internal string Transaction { get; set; }

        public Trade(string symbol, float price, float amount, string time, string type)
        {
            this.Symbol = symbol;
            this.Price = price;
            this.Amount = amount;
            this.Time = time;
            this.Transaction = type;
        }

        internal static Trade FromJson(Dictionary<string, object> JsonResult)
        {
            return new Trade(JsonResult["symbol"].ToString(), float.Parse(JsonResult["price"].ToString()), float.Parse(JsonResult["amount"].ToString()), JsonResult["time"].ToString(), JsonResult["transaction"].ToString());
        }
    }
}
