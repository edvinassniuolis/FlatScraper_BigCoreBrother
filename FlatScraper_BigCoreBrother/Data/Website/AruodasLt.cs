using FlatScraper_BigCoreBrother.Data.Scrape;
using FlatScraper_BigCoreBrother.Model.Interface;
using System.Collections.Specialized;

namespace FlatScraper_BigCoreBrother.Data.Website
{
    public class AruodasLt : IWebsite, IFlatRental
    {
        public ScrapeCriteria ScrapeCriteria { get; set; }
        public ScrapeCriteriaPart ScrapeCriteriaPart { get; set; }

        public NameValueCollection AppSettings { get; set; }

        public string Domain { get; set; }
        public string Order { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public string RoomFrom { get; set; }
        public string RoomTo { get; set; }
        public string PriceFrom { get; set; }
        public string PriceTo { get; set; }
        public string Address { get; set; }
        public string Act { get; set; }
        public string Page { get; set; }
        public string District { get; set; }
        public string MailSubject => "Aruodas List";
        public string MailBody { get; set; }

        public string Url => $"http://{Domain}/{Category}/{City}/?obj=4&FRegion={Address}" +
                             $"&FRoomNumMin={RoomFrom}&FRoomNumMax={RoomTo}" +
                             $"&FPriceMin={PriceFrom}&FPriceMax={PriceTo}" +
                             $"&FOrder={Order}&FDistrict={District}&act={Act}&Page={Page}";

    }

}
