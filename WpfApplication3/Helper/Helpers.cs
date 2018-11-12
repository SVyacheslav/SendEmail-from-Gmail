using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3.Helper
{
    public class Helpers
    {
        public static bool SendMail(string to, string subject, string body, 
            out string errMessage)
        {
            //1
            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress(to));
            msg.From = new MailAddress("info@kkb.kz");
            msg.Subject = subject;
            msg.Body = body;
            msg.Priority = MailPriority.High;

            //2
            SmtpClient client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(
                "pampkin220@gmail.com", "oooo1234")
            };

            //3
            try
            {
                client.Send(msg);
                errMessage = "Сообщение отправлено";
                return true;
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
                return false;
            }
        }
    }
}
