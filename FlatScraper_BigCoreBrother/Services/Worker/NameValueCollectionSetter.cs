using Log;
using System;
using System.Collections.Specialized;
using System.Configuration;

namespace FlatScraper_BigCoreBrother.Services.Worker
{
    public class NameValueCollectionSetter
    {
        public static NameValueCollection GetCustomNameValueCollection(string appSettings)
        {
            try
            {
                return (NameValueCollection)ConfigurationManager.GetSection(appSettings);
            }
            catch (Exception e)
            {
                Logger.Error("No such key in appSettings");
                Logger.Trace(e.StackTrace);
                throw;
            }

        }
    }
}
