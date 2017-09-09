using System.Text.RegularExpressions;

namespace FlatScraper_BigCoreBrother.Data.Scrape
{
    public class ScrapeCriteriaPart
    {
        public string Regex { get; set; }
        public RegexOptions RegexOptions { get; set; }
    }
}