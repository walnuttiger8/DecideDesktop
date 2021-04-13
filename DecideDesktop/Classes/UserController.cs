using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecideDesktop
{
    internal static class UserController
    {
        internal static User SignUp(string Address, Dictionary<string, object> UserValues)
        {
            var JsonResult = HTTPClient.SendRequest(Address + "/register", UserValues);
            var userData = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["result"].ToString());                         

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                User user = new User(userData["name"].ToString(), userData["password"].ToString(), userData["email"].ToString());
                return user;
            }
            else
            {
                
                return null;
            }
        }
        internal static bool LogIn(string Address, User user) //вход
        {
            Dictionary<string, object> UserData = new Dictionary<string, object>
            {
                {"name", user.Name },
                {"password", user.Password },
            };
            var JsonResult = HTTPClient.SendRequest(Address + "/login", UserData);

            int Success = Convert.ToInt32(JsonResult["success"]);

            if (Success == 1)
            {
                return true;
            }
            else if (Success == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
