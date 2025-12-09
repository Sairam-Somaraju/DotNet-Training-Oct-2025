using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11_25
{
    public sealed class SealedClassDemo
    {
        public string Email {  get; set; }
        public string GenericPassword { get; set; }
        public string LockNumber { get; set; }

        public void GetPersonalDetails()
        {
            Console.WriteLine("Enter the Email, Locker Info, GenericPassword");
            Email= Console.ReadLine();
            LockNumber= Console.ReadLine();
            GenericPassword= Console.ReadLine();

            Console.WriteLine("*************PersonalDetails***************");
            Console.WriteLine("Email: "+Email);
            Console.WriteLine("LockNumber: " + LockNumber);
            Console.WriteLine("GenericPassword: " + GenericPassword);

        }
    }
}
