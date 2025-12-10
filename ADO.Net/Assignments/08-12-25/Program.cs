using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_12_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectedArchitecture cn=new ConnectedArchitecture();
            //-----------TASK-1-------------------
            //Console.WriteLine("ENter the start date: ");
            // DateTime startdate= DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the end date");
            //DateTime  enddate= DateTime.Parse(Console.ReadLine());

            //cn.GetTransactions(startdate,enddate);
            //Console.ReadLine();

            //--------------TASK-2---------------
            //Console.WriteLine("Enter the Id: ");
            //int id=int.Parse(Console.ReadLine());
            //cn.GetCommonRecords(id);
            //Console.ReadLine();

            //---------------TASK-3---------------
            //cn.InsertRecordsusingtrans();
            //Console.ReadLine();

            //--------------------TASK-4---------------------
            //cn.InsertAndFetchIdentity();
            //Console.ReadLine();

            //----------------------TASK-5----------------------
            cn.MultiResultReader();
            Console.ReadLine();
        }
    }
}
