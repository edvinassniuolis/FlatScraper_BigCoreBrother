using System.Collections.Specialized;
using FlatScraper_BigCoreBrother.Data.Website;

namespace FlatScraper_BigCoreBrother.Services.Builder
{
    public class DomoPliusLtBuilder
    {
        public DomoPliusLt CreateFromAppSettings(NameValueCollection customAppSettings)
        {
            return new DomoPliusLt()
            {
                AppSettings = customAppSettings,
                Domain = customAppSettings["Domain"],
                Category = customAppSettings["Category"],
                City = customAppSettings["City"],
                RoomFrom = customAppSettings["RoomFrom"],
                RoomTo = customAppSettings["RoomTo"],
                PriceFrom = customAppSettings["PriceFrom"],
                PriceTo = customAppSettings["PriceTo"],
                Order = customAppSettings["Order"],
                OrderBy = customAppSettings["OrderBy"],
                Page = customAppSettings["Page"],
                Address = customAppSettings["Address"],
                ActionType = customAppSettings["ActionType"]
            };
        }
    }
}
