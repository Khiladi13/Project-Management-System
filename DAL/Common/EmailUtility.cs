using System.Configuration;
using System.Net;
using System.Net.Mail;


namespace ProjectManagementSystem.Common
{

    public class EmailUtility
    {
        public static void SendEmail(string ToEmail, string body)
        {
            // attach your url with id
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["Email"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
            smtp.EnableSsl = true;

            MailMessage msg = new MailMessage(ConfigurationManager.AppSettings["Email"].ToString(), ToEmail);
            msg.Subject = "Project Management System";
            msg.IsBodyHtml = true;
            //if we are making body via a c# then use '' instead of "" for hrefs
            //referanehttps://stackoverflow.com/questions/15754319/insert-a-link-in-to-a-email-send-using-c-sharp
            msg.Body = body;
            smtp.Send(msg);

        }
    }
}