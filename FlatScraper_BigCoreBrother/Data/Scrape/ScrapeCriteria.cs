using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FlatScraper_BigCoreBrother.Data.Scrape
{
    public class ScrapeCriteria
    {
        public string Data { get; set; }
        public string Regex { get; set; }
        public RegexOptions RegexOptions { get; set; }
        public List<ScrapeCriteriaPart> Parts { get; set; }

        public ScrapeCriteria()
        {
            Parts = new List<ScrapeCriteriaPart>();
        }
    }
}
