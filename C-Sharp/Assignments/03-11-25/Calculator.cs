using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_11_25
{
    internal class Calculator
    {
        //public void addition(int num1, int num2)
        //{
        //    Console.WriteLine("Addition is: " + (num1 + num2));
             
        //}
        //public void substraction(int num1, int num2)
        //{
        //    Console.WriteLine("Substraction is: " + (num1 - num2));
            
        //}



        public void calculator(int num1,int  num2, out int addResult, out int substraction, out int multiplication, out int division)
        {
            addResult = num1 + num2;
            substraction = num1 - num2;
            multiplication = num1*num2;
            division = num1/num2;
        }
    }
}
