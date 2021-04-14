using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecideDesktop.Classes
{
    internal static class UserController
    {
        internal static int SignUp(string Address, Dictionary<string, object> UserValues)
        {
            var JsonResult = HTTPClient.SendRequest(Address + "/register", UserValues);
            var userData = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                int userId = Convert.ToInt32(userData["user_id"]);
                return userId;
            }
            else
            {
                MessageBox.Show(JsonResult["message"].ToString());
                return 0;
            }
        }
        internal static int LogIn(string Address, Dictionary<string, object> UserValues)
        {
            var JsonResult = HTTPClient.SendRequest(Address + "/login", UserValues);
            var userData = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonResult["results"].ToString());

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                int userId = Convert.ToInt32(userData["user_id"]);
                return userId;
            }
            else
            {
                MessageBox.Show(JsonResult["message"].ToString());
                return 0;
            }
        }

        internal static User GetUser(string Address, int userId)
        {
            Dictionary<string, object> userIdData = new Dictionary<string, object>
            {
                {"user_id", userId }
            };

            var JsonResult = HTTPClient.SendRequest(Address + "/get_user", userIdData);

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                var thisUser = JsonConvert.DeserializeObject<User>(JsonResult["results"].ToString());
                return thisUser;
            }
            else
            {
                MessageBox.Show(JsonResult["message"].ToString());
                return null;
            }
        }

        internal static List<Wallet> GetWallets(string Address, int userId)
        {
            Dictionary<string, object> userIdData = new Dictionary<string, object>
            {
                {"user_id", userId }
            };

            var JsonResult = HTTPClient.SendRequest(Address + "/get_wallets", userIdData);

            if (Convert.ToInt32(JsonResult["success"]) == 1)
            {
                List<Wallet> wallets = JsonConvert.DeserializeObject<List<Wallet>>(JsonResult["results"].ToString());
                return wallets;
            }
            else
            {
                MessageBox.Show(JsonResult["message"].ToString());
                return null;
            }
        }
    }
}
