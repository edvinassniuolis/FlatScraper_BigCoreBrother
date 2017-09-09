using FlatScraper_BigCoreBrother.Model.Interface;
using Log;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace FlatScraper_BigCoreBrother.Services.Worker
{
    public class Downloader
    {
        private static List<string> _scrapedElements;
        private static IWebsite _website;

        public static void Download(IWebsite website)
        {
            try
            {
                using (var client = new WebClient())
                {
                    _website = website;
                    var downloadUrl = client.DownloadString(website.Url);
                    var scraper = new Scraper();

                    website.ScrapeCriteriaPart =
                            scraper.AddScrapeCriteriaPart(website.AppSettings["ScrapeCriteriaPart"],
                            RegexOptions.Singleline);
                    website.ScrapeCriteria = scraper.AddScrapeCriteria(downloadUrl,
                            website.AppSettings["ScrapeCriteria"], RegexOptions.Singleline, website.ScrapeCriteriaPart);

                    _scrapedElements = scraper.Scrape(website.ScrapeCriteria);
                    ScrapeFileManager.AppendToFile(_scrapedElements);
                }
            }

            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }
        }

        public static string TransformListToString()
        {
            string addedList = "";
            int count = 0;

            foreach (var element in _scrapedElements)
            {
                addedList = addedList + element + Environment.NewLine;
                count++;
            }

            Logger.Info($"{_website.MailSubject} links found: {count}");
            return addedList;
        }
    }
}
