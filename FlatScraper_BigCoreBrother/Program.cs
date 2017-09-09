using FlatScraper_BigCoreBrother.Services.Worker;
using Log;

namespace FlatScraper_BigCoreBrother
{
    public class Program
    {

        static void Main(string[] args)
        {
            Logger.Info("Started");

            var exe = new Executor();
            exe.Run();

            Logger.Info("Success");
        }


    }
}
