using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_25
{
    internal class LoggerMainMethod
    {
        public static void Main(string[] args)
        {
            Logger log = Logger.Instance;

            log.WriteLog("Application started");
            log.WriteLog("Log message number 1");
            log.WriteLog("Application ended");

            Console.WriteLine("Logs written successfully!");
            Console.ReadLine();
        }
    }
}
