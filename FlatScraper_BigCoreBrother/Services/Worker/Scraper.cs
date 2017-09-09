using FlatScraper_BigCoreBrother.Data.Scrape;
using FlatScraper_BigCoreBrother.Services.Builder;
using Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FlatScraper_BigCoreBrother.Services.Worker
{
    public class Scraper
    {
        public List<string> Scrape(ScrapeCriteria scrapeCriteria)
        {
            try
            {
                var scrappedElements = new List<string>();
                var matches = Regex.Matches(scrapeCriteria.Data, scrapeCriteria.Regex, scrapeCriteria.RegexOptions);

                foreach (Match match in matches)
                {
                    ScrapeByRegex(scrapeCriteria, scrappedElements, match);
                }

                return scrappedElements;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }

        }

        private void ScrapeByRegex(ScrapeCriteria scrapeCriteria, List<string> scrappedElements, Match match)
        {
            if (!scrapeCriteria.Parts.Any())
                scrappedElements.Add(match.Groups[0].Value);
            else
            {
                foreach (var part in scrapeCriteria.Parts)
                {
                    var matchedPart = Regex.Match(match.Groups[0].Value, part.Regex, part.RegexOptions);

                    if (matchedPart.Success)
                        scrappedElements.Add(matchedPart.Groups[1].Value);
                }
            }
        }

        public ScrapeCriteriaPart AddScrapeCriteriaPart(string regex, RegexOptions regexOptions)
        {
            try
            {
                return new ScrapeCriteriaPartBuilder()
                                .WithRegex(regex)
                                .WithRegexOptions(regexOptions)
                                .Build();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }

        }

        public ScrapeCriteria AddScrapeCriteria(string httpData, string regex, RegexOptions regexOptions, ScrapeCriteriaPart scrapeCriteriaPart)
        {
            try
            {
                return new ScrapeCriteriaBuilder()
                    .WithData(httpData)
                    .WithRegex(regex)
                    .WithRegexOptions(regexOptions)
                    .WithScrapeCriteriaParts(scrapeCriteriaPart)
                    .Build();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }

        }
    }
}