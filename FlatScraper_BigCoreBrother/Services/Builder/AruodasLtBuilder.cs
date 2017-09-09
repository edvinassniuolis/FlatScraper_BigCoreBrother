using System.Collections.Specialized;
using FlatScraper_BigCoreBrother.Data.Website;

namespace FlatScraper_BigCoreBrother.Services.Builder
{
    public class AruodasLtBuilder
    {
        public AruodasLt CreateFromAppSettings(NameValueCollection customAppSettings)
        {
            return new AruodasLt()
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
                Act = customAppSettings["Act"],
                Page = customAppSettings["Page"],
                District = customAppSettings["District"],
                Address = customAppSettings["Address"]
            };
        }
    }
}
