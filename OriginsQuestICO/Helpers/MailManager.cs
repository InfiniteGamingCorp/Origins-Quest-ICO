using OriginsQuestICO.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace OriginsQuestICO.Helpers
{
    public static class MailManager
    {
        public static async Task<bool> SendEmailAsync(EmailModel email)
        {
            try
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("contact@originsquest.com"));  // replace with valid value 
                message.From = new MailAddress(email.FromEmail);  // replace with valid value
                message.Subject = "Newsletter Subscription";
                message.Body = string.Format(body, email.FromName, email.FromEmail, email.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "marius@originsquest.com",  // replace with valid value
                        Password = "e-D6$S&!S%&%ws_W"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "mail.originsquest.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = false;
                    await smtp.SendMailAsync(message);
                    return true;
                }
            }
            catch (Exception e)
            {                
                return false;
            }
        }
    }
}