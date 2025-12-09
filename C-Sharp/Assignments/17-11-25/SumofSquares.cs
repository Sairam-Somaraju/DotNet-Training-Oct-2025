using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_11_25
{
    public static class NumberExtension
    {
        public static int SumOfSquares(this IEnumerable<int> numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i*i;
            }
            return sum;
        }
    }
    internal class SumofSquares
    {
        public static void Main(string[] args)
        {
            List<int> nums = new List<int> { 2,3,4};
            Console.WriteLine("SumOfSquares is: "+ nums.SumOfSquares());
            
        }
    }
}
