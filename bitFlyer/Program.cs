using System;

namespace bitFlyer
{
    class Program
    {
        static void Main(string[] args)
        {
            // ready for use IOC, here is just demo
            var startup = new Startup(new ReadFileService(), new BlockProcessingService(500000), new OutputResult());
            startup.Run();
            Console.Read();
        }
    }
}
