using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_11_25
{
    public static class Extension
    {
       public static bool IsUpper(this string value) => value == value.ToUpper();
         
    }
     
    internal class CheckUpperCaseOrNot
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name: ");
            string name=Console.ReadLine();
            Console.WriteLine(name.IsUpper());
            
        }
    }
}
