using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace DecideDesktop
{
    internal static class HTTPClient
    {
        internal const string Address = "http://127.0.0.1:5000";
        internal static Dictionary<string, object> SendRequest(string Address, Dictionary<string, object> Dictionary)
        {
            string Result = "";
            dynamic JsonObject = JsonConvert.SerializeObject(Dictionary);

            byte[] byteArray = Encoding.UTF8.GetBytes(JsonObject.ToString());

            WebRequest Request = WebRequest.Create(Address);
            Request.Method = "POST";
            Request.ContentType = "application/json";
            Request.ContentLength = byteArray.Length;

            using (Stream dataStream = Request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

            using (StreamReader streamReader = new StreamReader(Response.GetResponseStream()))
            {
                Result = streamReader.ReadToEnd();
            }

            dynamic JsonDeserializedObject = JsonConvert.DeserializeObject<Dictionary<string, object>>(Result);
            return JsonDeserializedObject;
        }
    }
}