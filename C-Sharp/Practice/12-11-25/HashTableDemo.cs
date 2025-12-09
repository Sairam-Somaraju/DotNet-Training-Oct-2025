using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_11_25
{
    internal class HashTableDemo
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 200);
            ht.Add("1", "sairam");
            ht.Add("id", "102");
            ht.Add("location", "chennai");
            ht["email"] = "sairam@gmail.com";
            ht[56] = "Test Value";

            Console.WriteLine("first position value: " + ht[1]);
            Console.WriteLine("elements in hashtable: " + ht.Count);
            Console.WriteLine("key is: " + ht.ContainsKey("id"));
            Console.WriteLine("value is: " + ht.ContainsValue("location"));

            Console.WriteLine("Hashtable Keys are: ");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("key: " + item);
            }

            Console.WriteLine("Hashtable values are: ");
            foreach (var item in ht.Values)
            {
                Console.WriteLine("value: "+item);
            }

            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+"->"+item.Value);
            }

            object[] keyArray = new object[ht.Keys.Count];
            ht.Keys.CopyTo(keyArray, 0);
            Console.WriteLine("\n after copying all keys into keyArray");

            foreach (var item in keyArray)
            {
                Console.WriteLine(item);
            }
            Hashtable ht2 = new Hashtable();
            foreach(DictionaryEntry item in ht)
            {
                ht2[item.Key] = item.Value;
            }

            Console.WriteLine("after store values one hashtable to another hashtable");

            foreach(DictionaryEntry item in ht2)
            {
                Console.WriteLine(item.Key+" -> "+item.Value);
            }

            Console.ReadLine();
        }
    }
}
