using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_25
{
    internal class Logger
    {
        private static Logger _instance = null;
        private static readonly object _lock = new object();
        private Logger() { }
        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Logger();

                    return _instance;
                }
            }
        }
        public void WriteLog(string message)
        {
            File.AppendAllText("log.txt", message + Environment.NewLine);
            Console.WriteLine("Log written: " + message);
        }
    }
}
