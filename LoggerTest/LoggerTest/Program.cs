using MyConsoleApp.Logging;

namespace MyConsoleApp.Main
{
    class MyConsoleApp
    {
        static void Main(string[] args)
        {
            Logger log = new Logger(typeof(MyConsoleApp));
            log.Debug("Hello World!");
        }
    }
}
