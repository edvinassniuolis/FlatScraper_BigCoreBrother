using System.Text.RegularExpressions;
using FlatScraper_BigCoreBrother.Data.Scrape;

namespace FlatScraper_BigCoreBrother.Services.Builder
{
    public class ScrapeCriteriaPartBuilder
    {
        private string _regex;
        private RegexOptions _regexOptions;

        public ScrapeCriteriaPartBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _regex = string.Empty;
            _regexOptions = RegexOptions.None;
        }

        public ScrapeCriteriaPartBuilder WithRegex(string regex)
        {
            _regex = regex;
            return this;
        }

        public ScrapeCriteriaPartBuilder WithRegexOptions(RegexOptions regexOptions)
        {
            _regexOptions = regexOptions;
            return this;
        }

        public ScrapeCriteriaPart Build()
        {
            var scrapeCriteriaPart = new ScrapeCriteriaPart()
            {
                Regex = _regex,
                RegexOptions = _regexOptions
            };

            return scrapeCriteriaPart;
        }
    }
}