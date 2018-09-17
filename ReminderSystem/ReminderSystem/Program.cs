using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ReminderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SendEmail("tuje@cphbusiness.dk", "Reminder", "We are looking forward to see you...");

            string resp = p.SendSms("4511223344", "This is a message2", "Santa");
            Console.WriteLine(resp);
        }

        public void SendEmail(string emailTo, string subject, string body)
        {
            //Gmail credentials
            string from = "youremail@gmail.com";
            string pass = "password";

            MailMessage mail = new MailMessage(from, emailTo);
            mail.Subject = subject;
            mail.Body = body;

            SmtpClient client = new SmtpClient();
            // client.Port = 25;
            client.Port = 587;
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(from, pass);
            client.Host = "smtp.gmail.com";
            client.Send(mail);
        }

        public string SendSms(string msisdn, string message, string from)
        {
            string username = "cphxxx";
            string apikey = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string basicauth = Convert.ToBase64String(Encoding.UTF8.GetBytes(username +":"+apikey));

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
