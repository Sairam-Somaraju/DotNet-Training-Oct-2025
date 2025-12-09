using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2025
{
    class log
    {
        public void Log(string message)
        {
            Console.WriteLine($"Message : {message}");
        }
        public void Log(string message, int level)
        {
            Console.WriteLine($"Messsage : {message} , Level {level}");
        }
        public void Log(string message, DateTime time)
        {
            Console.WriteLine($"Message : {message} , Time {time}");
        }
        public void Log(string message, int level, DateTime time)
        {
            Console.WriteLine($"Message : {message} , Level {level} , Time {time}");
        }

    }
    internal class LogMethods
    {
        public static void Main(string[] args)
        {
            log l= new log();
            l.Log("System Started");
            l.Log("overTime warning", 2);
            l.Log("System Logout", DateTime.Now);
            l.Log("System Closed", 2, DateTime.Now);
        }
    }
}
