using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_11_25
{
    public delegate void Log();

    internal class Demo8
    {
        
        public static void Main(string[]args)
        {
            Log logger = null;
            logger += logtoConsole;
            logger += logtoFile;
            logger += logtoDatabase;
            logger();          

        }
        public static void logtoConsole()
        {
            Console.WriteLine("log to console");
        }
        public static void logtoFile()
        {
            Console.WriteLine("logtofile");
        }
        public static void logtoDatabase()
        {
            Console.WriteLine("logto database");
        }
    }
    }

