using FlatScraper_BigCoreBrother.Model.Interface;

namespace FlatScraper_BigCoreBrother.Data.Mail.Client
{
    public class GoogleMailClient : IMailClient
    {
        public string Host => "smtp.gmail.com";
        public int Port => 587;
    }
}
