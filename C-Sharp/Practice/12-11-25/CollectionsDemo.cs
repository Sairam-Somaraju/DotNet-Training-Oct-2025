using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_11_25
{
    internal class CollectionsDemo
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(101);
            al.Add('a');
            Console.WriteLine("After adding the two elements in list capacity is: "+al.Capacity);

            al.Add("sai");
            al.Add(true);
            al.Add(10.2);
            Console.WriteLine("After adding the two elements in list capacity is: "+al.Capacity);

            //to remove the particular element
            al.Remove(true);
            Console.WriteLine("After removing true capacity is: " + al.Capacity);

            foreach(var i in al)
            {
                Console.WriteLine(i);
            }

            // add the all elements of onelist to anotherlist
            ArrayList employeelist = new ArrayList() { 101, "venkat", "ASE", "Bengaluru" };
            al.AddRange(employeelist);
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }

            //to check Conatins or not 
            Console.WriteLine(al.Contains("venkat"));

            //to insert element
            al.Insert(1, "Sairam");

            //to check Index number
            Console.WriteLine(al.IndexOf("Bengaluru"));

            //to findout last  index
           Console.WriteLine(al.LastIndexOf(al));

            Console.WriteLine("All the elements in arraylist: ");
            foreach(var i in al)
            {
                Console.WriteLine(i);
            }

            // to count the number of elements in List
            Console.WriteLine(al.Count);

            Console.WriteLine($"arraylist[4] is: {al[4]}");

            // to print the range  and print 5 values from 3
            ArrayList al3 = al.GetRange(3, 5);
            Console.WriteLine("array list3 values are ");

            foreach (var item in al3)
            {
                Console.WriteLine(item);
            }

            //to reverse the element
            Console.WriteLine("After reversing the arraylist");
            al3.Reverse();
            foreach(var item in al3)
            {
                Console.WriteLine(item);
            }

            //to remove particular position element

            Console.WriteLine("after Remove(1) arraylist 3\"");
            al3.RemoveAt(1);
            foreach( var item in al3)
            { 
                Console.WriteLine(item);
            }

            //to remove the range from 2nd position to twoelements 
            Console.WriteLine("After removerange(2,2) arraylist3");
            al3.RemoveRange(2, 2);
            foreach( var item in al3)
            { 
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
