using log4net;
using System;

namespace MyConsoleApp.Logging
{
    public class Logger: ILogger
    {
        private ILog log;
        public Logger(Type t)
        {
            log = log4net.LogManager.GetLogger(t);
        }

        public void Debug(string message)
        {
            log.Debug(message);
        }
    }
}
