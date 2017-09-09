namespace FlatScraper_BigCoreBrother.Data.Mail.Data
{
    public class EMail
    {
        public string Subject { get; set; }
        public string Body { get; set; }

        public EMail(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }
    }
}
