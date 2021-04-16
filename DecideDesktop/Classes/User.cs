using DecideDesktop.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecideDesktop
{
    internal class User
    {
        internal string Name { get; set; }
        internal string Email { get; set; }
        internal float Balance { get; set; }
        internal List<Wallet> Wallets { get; set; }

        public User(string Name, string Email, float Balance)
        {
            this.Name = Name;
            this.Email = Email;
            this.Balance = Balance;
        }

        public User() { } 

        internal static User FromJson(Dictionary<string, object> JsonResult)
        {
            return new User(JsonResult["name"].ToString(), JsonResult["email"].ToString(), float.Parse(JsonResult["balance"].ToString()));
        }
    }
}
