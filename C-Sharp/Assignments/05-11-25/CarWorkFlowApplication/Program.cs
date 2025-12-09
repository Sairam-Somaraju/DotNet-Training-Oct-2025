using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AutoCareSolutions
{
    class Vehicle
    {
         private string registrationNumber;
        private string ownerName;

         protected int serviceCount;

         public Vehicle(string regNo, string owner)
        {
            registrationNumber = regNo;
            ownerName = owner;
            serviceCount = 0;  
            Console.WriteLine("Vehicle Base Class Constructor Called");
        }

         private void ShowRegistration()
        {
            Console.WriteLine($"Vehicle Registration: {registrationNumber}");
            Console.WriteLine($"Owner Name: {ownerName}");
        }

         protected void DisplayBasicInfo()
        { 
            ShowRegistration(); 
        }
        public void DisplayVehicleInfo()
        {
             
            DisplayBasicInfo();
            Console.WriteLine($"Total Services Done: {serviceCount}");
        }
          
        public void UpdateServiceCount()
        {
            serviceCount++;
            Console.WriteLine($" Vehicle Service Count Updated: {serviceCount}");
        }
    }
 
    class Car : Vehicle
    {
         
        private string model;
        private string brand;

         public Car(string regNo, string owner, string brand, string model)
            : base(regNo, owner) 
        {
            this.brand = brand;
            this.model = model;
            Console.WriteLine("Car Derived Class Constructor Called");
        }

         private void PerformInspection()
        {
            Console.WriteLine("Car inspection in progress...");
        }

         protected void PerformMaintenance()
        {
            
            UpdateServiceCount();  
        }

         public void ShowCarServiceWorkflow()
        {
            Console.WriteLine("\n*** CAR SERVICE WORKFLOW ***");
            DisplayVehicleInfo();   
            PerformInspection(); 
            PerformMaintenance();   
            Console.WriteLine("Car service completed successfully!\n");
        }
    }
 
    internal class CarWorkFlowApplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to AutoCare Solutions");

            
            Car myCar = new Car("AP16AF5251", "Sairam", "Thar", "Mahindra");
            myCar.ShowCarServiceWorkflow();

            Car myCar1 = new Car("AP16BC6220", "Rajesh", "Innova", "Toyota");
            myCar.ShowCarServiceWorkflow();

        }
    }
}