using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Logger : ILog
    {
        //Other way of implementing a singleton pattern
        private static Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger()); 
        private Logger() { }
        
        // Common way of implement singleton pattern
        //public static Logger getLogger()
        //{
        //    if (_instance == null)
        //            _instance = new Logger();
        //    return _instance;
        //}
        public static Logger Instance
        {
            get { return _instance.Value; }
        }
        public void debug(string message)
        {
            Console.WriteLine($"\n [Debug] - { DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt")} : {message}");
        }
        public void error(string message)
        {
            Console.WriteLine($"\n [Error] - { DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt")} : {message}");
        }
        public void info(string message)
        {
            Console.WriteLine($"\n [Info] - { DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt")} : {message}");
        }
        public void warning(string message)
        {
            Console.WriteLine($"\n [Warning] - { DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt")} : {message}");
        }
    }
}
