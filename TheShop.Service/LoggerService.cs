using System;
using TheShop.Common;

namespace TheShop.Service
{
    public class LoggerService : ILoggerService
    {
        public void Info(string message)
        {
            Console.WriteLine(Resources.Info + message);
        }

        public void Error(string message)
        {
            Console.WriteLine(Resources.Error + message);
        }

        public void Debug(string message)
        {
            Console.WriteLine(Resources.Debug + message);
        }
    }
}
