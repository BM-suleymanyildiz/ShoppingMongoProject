
using System.Net;
using System.Net.Mail;

namespace ShoppingNightMongo.Services.MailSenderService
{
    public class MailSender : IMailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SmtpClient("smtp.gmail.com",587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("", "")
            };
            return client.SendMailAsync(new MailMessage(from: "", to: email, subject, message));
        }
    }
}
