using FlatScraper_BigCoreBrother.Data.Mail.Client;
using FlatScraper_BigCoreBrother.Data.Mail.Data;
using FlatScraper_BigCoreBrother.Data.User;
using FlatScraper_BigCoreBrother.Data.Website;
using FlatScraper_BigCoreBrother.Model.Interface;
using FlatScraper_BigCoreBrother.Services.Builder;
using Log;
using System;
using System.Collections.Specialized;

namespace FlatScraper_BigCoreBrother.Services.Worker
{
    public class Executor
    {
        private User _sender;
        private User _receiver;
        private EMail _eMail;
        private IMailClient _mailClient;
        private NameValueCollection _customAppSettings;

        public void Run()
        {
            try
            {
                RunFlatWebsiteScraper("domoPliusAppSettings", new DomoPliusLt());
                RunFlatWebsiteScraper("aruodasAppSettings", new AruodasLt());
                Console.WriteLine("Test");

                ScrapeFileManager.ReadFromFile();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }

        }

        private void RunFlatWebsiteScraper(string appSettings, IWebsite iWebsite)
        {
            _customAppSettings = NameValueCollectionSetter.GetCustomNameValueCollection(appSettings);

            if (iWebsite is AruodasLt)
                iWebsite = new AruodasLtBuilder().CreateFromAppSettings(_customAppSettings);
            if (iWebsite is DomoPliusLt)
                iWebsite = new DomoPliusLtBuilder().CreateFromAppSettings(_customAppSettings);

            Downloader.Download(iWebsite);

            iWebsite.MailBody = Downloader.TransformListToString();
            SendEmail(iWebsite.MailSubject, iWebsite.MailBody);
        }

        private void SendEmail(string subject, string body)
        {
            _sender = new User("Edvinas", "edvinas.sniuolis@gmail.com")
            {
                Password = "7557asas"
            };
            _receiver = new User("You", "edvinas.sniuolis@gmail.com");
            _mailClient = new GoogleMailClient();
            _eMail = new EMail(subject, body);

            EMailSender.Send(_sender, _receiver, _eMail, _mailClient);
        }
    }
}
