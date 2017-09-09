using FlatScraper_BigCoreBrother.Data.Scrape;

namespace FlatScraper_BigCoreBrother.Data.Website
{
    public class Craigslist
    {
        //search
        public string Method { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public string Url => $"http://{City.Replace(" ", string.Empty)}.craigslist.org/{Method}/{Category}";
        public ScrapeCriteria ScrapeCriteria { get; set; }
        public ScrapeCriteriaPart ScrapeCriteriaPart { get; set; }

    }
}
