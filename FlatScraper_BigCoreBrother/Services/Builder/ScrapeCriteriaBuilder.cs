using System.Collections.Generic;
using System.Text.RegularExpressions;
using FlatScraper_BigCoreBrother.Data.Scrape;

namespace FlatScraper_BigCoreBrother.Services.Builder
{
    public class ScrapeCriteriaBuilder
    {
        private string _data;
        private string _regex;
        private RegexOptions _regexOptions;
        private List<ScrapeCriteriaPart> _parts;

        public ScrapeCriteriaBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _data = string.Empty;
            _regex = string.Empty;
            _regexOptions = RegexOptions.None;
            _parts = new List<ScrapeCriteriaPart>();
        }

        public ScrapeCriteriaBuilder WithData(string data)
        {
            _data = data;
            return this;
        }
        public ScrapeCriteriaBuilder WithRegex(string regex)
        {
            _regex = regex;
            return this;
        }
        public ScrapeCriteriaBuilder WithRegexOptions(RegexOptions regexOptions)
        {
            _regexOptions = regexOptions;
            return this;
        }
        public ScrapeCriteriaBuilder WithScrapeCriteriaParts(ScrapeCriteriaPart part)
        {
            _parts.Add(part);
            return this;
        }

        public ScrapeCriteria Build()
        {
            var scrapeCriteria = new ScrapeCriteria()
            {
                Data = _data,
                Parts = _parts,
                Regex = _regex,
                RegexOptions = _regexOptions
            };

            return scrapeCriteria;
        }
    }
}