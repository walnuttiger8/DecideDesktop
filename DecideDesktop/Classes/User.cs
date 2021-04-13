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

        public User(string Name, string Password, string Email)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
        }

        public User() { }
    }
}
