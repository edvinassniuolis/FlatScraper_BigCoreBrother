using FlatScraper_BigCoreBrother.Data.Scrape;

namespace FlatScraper_BigCoreBrother.Model.Interface
{
    public interface IScrapeCriteriaBuilder
    {
        ScrapeCriteria ScrapeCriteria { get; set; }
        ScrapeCriteriaPart ScrapeCriteriaPart { get; set; }
    }
}
