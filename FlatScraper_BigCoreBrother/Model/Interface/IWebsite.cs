using System.Collections.Specialized;

namespace FlatScraper_BigCoreBrother.Model.Interface
{
    public interface IWebsite : IScrapeCriteriaBuilder, IMailFormat
    {
        string Domain { get; set; }
        string Url { get; }
        string Order { get; set; }
        string Page { get; set; }
        NameValueCollection AppSettings { get; set; }
    }
}
