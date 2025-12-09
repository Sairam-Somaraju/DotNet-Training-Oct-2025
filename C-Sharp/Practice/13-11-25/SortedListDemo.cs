using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_11_25
{
    internal class SortedListDemo
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(102, "Rice");
            sl.Add(104, "Biryani");
            sl.Add(101, "FriedRice");
            sl.Add(103, "Pizza");
            sl.Add(105, "Burger");

            Console.WriteLine("First Item: " + sl.Keys[0]);
            Console.WriteLine("Last item: " + sl.Values[sl.Count-1 ]);

            foreach (var item in sl)
            {
                Console.WriteLine("Key: " + item.Key + " " + " Value: " + item.Value);
            }

            Console.WriteLine("Enter the key to search :");
            int search = Convert.ToInt32(Console.ReadLine());

            if (sl.ContainsKey(search))
            {
                Console.WriteLine("Item found: " + sl[search]);
            }
            else
            {

                Console.WriteLine("Item Not Found");

            }

            Console.WriteLine("Enter the value to search :");
            String valueSearch = Console.ReadLine();

            if (sl.ContainsValue(valueSearch))
            {
                Console.WriteLine("Item found: " +  sl.IndexOfValue(valueSearch));
            }
            else
            {

                Console.WriteLine("Item Not Found");

            }

            Console.WriteLine("Enter the key to remove :");
            int remove = Convert.ToInt32(Console.ReadLine());
            if (sl.ContainsKey(remove))
            {
                Console.WriteLine("Item found: "+sl.Remove(remove));

            }
            else
            {
                Console.WriteLine("Item not found");
            }
            Console.WriteLine("Enter the key to update :");
            int update = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the new Value");
            String newValue= Console.ReadLine();
            sl[update] = newValue;
            
            foreach(var item in sl)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }

            sl.RemoveAt(0);
            Console.WriteLine("After removing the key value pair by index 0 ");

            foreach (var item in sl)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
            Console.WriteLine("Enter the value to GetIndex :");
            String getIndex =  Console.ReadLine();

            Console.WriteLine("Index position is: "+ sl.IndexOfValue(getIndex));
            foreach(var item in sl)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);

            }
        }
    }
}
