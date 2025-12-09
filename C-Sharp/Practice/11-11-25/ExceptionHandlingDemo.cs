using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_11_25
{
    internal class ExceptionHandlingDemo
    {
        public static void MethodDivide()
        {

            try
            {
                int x, y, z;
                Console.WriteLine("Enter the two numbers: ");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
                Console.WriteLine($"Result: {z}");

            }
            catch (DivideByZeroException ex1)
            {
                throw new Exception($"exception occured while divide by 0 {ex1.Message}\nsource: {ex1.Source}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            Console.ReadLine();
        }
        public static void Main(String[] args)
        {
            try
            {
                MethodDivide();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught in Main: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
