using FlatScraper_BigCoreBrother.Data.Scrape;
using FlatScraper_BigCoreBrother.Model.Interface;
using System.Collections.Specialized;

namespace FlatScraper_BigCoreBrother.Data.Website
{
    public class DomoPliusLt : IFlatRental, IWebsite
    {
        public ScrapeCriteria ScrapeCriteria { get; set; }
        public ScrapeCriteriaPart ScrapeCriteriaPart { get; set; }

        public NameValueCollection AppSettings { get; set; }

        public string Name { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public string RoomFrom { get; set; }
        public string RoomTo { get; set; }
        public string PriceFrom { get; set; }
        public string PriceTo { get; set; }
        public string Domain { get; set; }
        public string Order { get; set; }
        public string Page { get; set; }
        public string ActionType { get; set; }
        public string Address { get; set; }
        public string OrderBy { get; set; }
        public string MailSubject => "DomoPlius List";
        public string MailBody { get; set; }

        public string Url => $"https://{Domain}/skelbimai/{Category}?action_type={ActionType}" +
                             $"&address_1={Address}&category_search=1&" +
                             $"flat_rooms_from={RoomFrom}&flat_rooms_to={RoomTo}" +
                             $"&order_by={OrderBy}&order_direction={Order}" +
                             $"&sell_price_from={PriceFrom}&sell_price_to={PriceTo}" +
                             $"&page_nr={Page}";
    }
}
