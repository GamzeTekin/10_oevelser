using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _48
{
    public static class APIhelper
    {
        static dynamic APIProcess(string url) 
        {
            var webRequest = WebRequest.Create(string.Format(@"{0}", url));

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                return reader.ReadToEnd();
            }
        }

        public static string reader(string city)
        {
            string content = APIProcess($"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid=73c9d2f3fa70a94f702677efafd617ad");
            var temp = content.Substring(content.IndexOf("temp")).Split(',')[0].Split(':')[1];
           
            return temp; 
        }
    }


}
