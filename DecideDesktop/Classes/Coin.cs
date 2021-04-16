using Newtonsoft.Json;
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

        internal static Coin FromJson(string JsonResult)
        {
            var JsonDeser = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult);
            return new Coin(JsonDeser["symbol"].ToString(), float.Parse(JsonDeser["price"].ToString()));
        }

        internal static Coin FromJson(Dictionary<string, object> JsonResult)
        {
            return new Coin(JsonResult["symbol"].ToString(), float.Parse(JsonResult["price"].ToString()));
        }
    }
}
