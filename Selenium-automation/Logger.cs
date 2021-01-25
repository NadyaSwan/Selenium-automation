using log4net;
using log4net.Config;

namespace Selenium_automation
{
    public static class Logger
    {
        public static ILog Log { get; } = LogManager.GetLogger("ConsoleLogger");

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }
    }
}
