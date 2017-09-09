namespace FlatScraper_BigCoreBrother.Model.Interface
{
    public interface IMailFormat
    {
        string MailSubject { get; }
        string MailBody { get; set; }
    }
}
