using Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlatScraper_BigCoreBrother.Services.Worker
{
    public class ScrapeFileManager
    {
        static string filename = "flatlist.txt";

        public static void AppendToFile(List<string> scrapedList)
        {
            try
            {
                File.AppendAllLines(filename, scrapedList);
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }
        }

        public static void WriteToFile(List<string> scrapedList)
        {
            try
            {
                File.WriteAllLines(filename, scrapedList);
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }
        }

        public static void ReadFromFile()
        {
            try
            {
                var scrapedAllLines = File.ReadAllLines(filename);
                List<string> scrapedAllLinesNoDublicates = scrapedAllLines.Distinct().ToList();

                WriteToFile(scrapedAllLinesNoDublicates);

            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                throw;
            }
        }
    }
}