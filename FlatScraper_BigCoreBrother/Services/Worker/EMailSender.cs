using FlatScraper_BigCoreBrother.Data.Mail.Data;
using FlatScraper_BigCoreBrother.Data.User;
using FlatScraper_BigCoreBrother.Model.Interface;
using Log;
using System;
using System.Net;
using System.Net.Mail;

namespace FlatScraper_BigCoreBrother.Services.Worker
{
    public class EMailSender
    {
        public static void Send(User sender, User receiver, EMail email, IMailClient mailClient)
        {
            var fromAddress = new MailAddress(sender.EmailAddress, sender.Name);
            var toAddress = new MailAddress(receiver.EmailAddress, receiver.Name);
            var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = email.Subject,
                Body = email.Body
            };

            var smtp = new SmtpClient
            {
                Host = mailClient.Host,
                Port = mailClient.Port,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, sender.Password)
            };

            try
            {
                using (message)
                {
                    smtp.Send(message);
                }

            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }

        }
    }
}
