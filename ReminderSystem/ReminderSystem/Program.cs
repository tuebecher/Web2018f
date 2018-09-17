using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReminderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string resp = p.SendSms("4511223344", "This is a message2", "Santa");
            Console.WriteLine(resp);
        }



        public string SendSms(string msisdn, string message, string from)
        {
            string username = "cphxxx";
            string apikey = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string basicauth = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(username +":"+apikey));


            string url = "https://api.cpsms.dk/v2/simplesend/"
                +msisdn+"/"+ System.Uri.EscapeDataString(message)+"/"+ System.Uri.EscapeDataString(from);

            using (WebClient client = new WebClient())
            {
                client.Headers["Authorization"] = "Basic "+basicauth;
                return client.DownloadString(url);
            }
        }

    }
}
