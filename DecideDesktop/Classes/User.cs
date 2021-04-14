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
        internal string Password { get; set; }
        internal string Email { get; set; }
        internal float Balance { get; set; }
        internal List<Wallet> Wallets { get; set; }

        public User(string Name, string Password, string Email, float Balance, List<Wallet> wallets)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.Balance = Balance;
            this.Wallets = wallets;
        }

        public User() { } 
    }
}
