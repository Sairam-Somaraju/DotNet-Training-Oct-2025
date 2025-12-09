using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2025
{
   public  class Vehicle
    {
        public virtual void  Start()
        {
            Console.WriteLine(" Vehicle: run for pre-run Checks");
        }
    }
    public class Car: Vehicle
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("CAR : start with key");
        }
    }
    public class ElectriCar : Car
    {
        public sealed override void Start()
        {
            base.Start();
            Console.WriteLine("ElectriCar: Start with button");
        }
    }
    internal class SealedMethodDemo
    {
        public static void Main(string[] args)
        {
            ElectriCar Ec = new ElectriCar();
            Ec.Start();
             
        }
    }
}
