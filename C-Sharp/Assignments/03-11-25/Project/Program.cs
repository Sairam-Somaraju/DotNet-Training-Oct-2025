using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            salary();
            Student();
            onlineShopping();
            passwordChecking();
            Restaraunt();
            movieTickets();
            trafficSignal();
        }
        public static void salary()
        {
            int sal;
            Console.WriteLine("Enter the Salary: ");
            sal = Convert.ToInt32(Console.ReadLine());
            int exp;
            Console.WriteLine("Enter the number years Experience..");
            exp = Convert.ToInt32(Console.ReadLine());
            if (exp > 10)
            {

                int amount = sal * 20 / 100;

                Console.WriteLine("Total salary: " + (amount + sal));
            }
            else if (exp > 5 && exp < 10)
            {
                int amount = sal * 10 / 100;

                Console.WriteLine("Total salary: " + (amount + sal));
            }
            else
            {
                int amount = sal * 5 / 100;

                Console.WriteLine("Total salary: " + (amount + sal));
            }
            Console.WriteLine("*****************");
            Console.ReadLine();
        }

        public static void Student()
        {
            String stuName;
            Console.WriteLine("ENter the Student name :");
            stuName = Console.ReadLine();
            int marks;
            Console.WriteLine("Enter the Student matrks :");
            marks = Convert.ToInt16(Console.ReadLine());
            if (marks >= 90)
            {
                Console.WriteLine("Student Grade is: A+");
            }
            else if (marks >= 80 && marks <= 89)
            {
                Console.WriteLine("Student Grade is: A");
            }
            else if (marks >= 70 && marks <= 79)
            {
                Console.WriteLine("Student Grade is: B");
            }
            else if (marks >= 60 && marks <= 69)
            {
                Console.WriteLine("Student Grade is: C");
            }
            else if (marks >= 50 && marks <= 59)
            {
                Console.WriteLine("Student Grade is: D");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.WriteLine("*****************");
            Console.ReadLine();
        }

        public static void onlineShopping()
        {
            int purAmount;
            Console.WriteLine("ENter the purchase Amount..");
            purAmount = Convert.ToInt32(Console.ReadLine());
            if (purAmount < 1000)
            {
                Console.WriteLine("No discount");

            }
            else if (purAmount >= 1000 && purAmount <= 5000)
            {


                Console.WriteLine("Final amount after discount: " + ((purAmount) - purAmount * 10 / 100));
            }
            else
            {


                Console.WriteLine("Final amount after discount: " + ((purAmount) - purAmount * 20 / 100));
            }
            Console.WriteLine("*****************");
            Console.ReadLine();
        }
        public static void passwordChecking()
        {
            String password;
            Console.WriteLine("Enter the Password...");
            password = Console.ReadLine();

            if (password.Length < 6)
            {
                Console.WriteLine("Password Strenth is: Weak..");
            }
            else if (password.Length >= 6 && password.Length <= 10)
            {
                Console.WriteLine("Password Strenth is: Medium.. ");
            }
            else
            {
                Console.WriteLine("Password Strenth is: Strong..");
            }
            Console.WriteLine("*****************");
            Console.ReadLine();
        }
        public static void Restaraunt()
        {
            int billAmount;
            Console.WriteLine("Enter the bill Amount..");
            billAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of persons..");
            int persons = Convert.ToInt32(Console.ReadLine());

            if (billAmount > 1000)
            {
                double gst = 5;
                double serviceCharge = 10;
                double total = ((gst + serviceCharge) / 100) * billAmount;
                double totalAmount = total + billAmount;
                Console.WriteLine("Each person Should pay: " + (totalAmount / persons));
            }
            Console.WriteLine("*****************");
            Console.ReadLine();

        }
        public static void movieTickets()
        {
            Console.WriteLine("Enter the age...");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the showtime..");
            int time = Convert.ToInt32(Console.ReadLine());

            if (age < 12)
            {
                Console.WriteLine("Ticket price is: " + 150);
            }
            else if (age >= 12 && time <= 18)
            {
                Console.WriteLine("Ticket Price is: " + 250);
            }
            else
            {
                Console.WriteLine("Ticket price is: " + 300);
            }
            Console.WriteLine("*****************");
            Console.ReadLine();
        }
        public static void trafficSignal()
        {
            Console.WriteLine("Enetr the colour..");
            string colour = Console.ReadLine();
            if (colour == "Red")
            {
                Console.WriteLine("Action: Stop.");
            }
            else if (colour == "Yellow")
            {
                Console.WriteLine("Action: Get Ready");

            }
            else
            {
                Console.WriteLine("Action: Go..");
            }
            Console.WriteLine("*****************");
            Console.ReadLine();
        }
    }
}
