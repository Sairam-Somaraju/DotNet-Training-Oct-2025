using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_12_25
{
    internal class task_6
    {
        public void ReadXMLDate()
        {
            DataSet ds= new DataSet();
            ds.ReadXml("C:\\INFINITE-Oct2025\\C#\\Assignments\\09-12-25\\Customer.xml");

            DataTable dt =ds.Tables["cust"];

            Console.WriteLine("Customer details from XML");

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["CUSTID"]);
                Console.WriteLine(row["CUSTNAME"]);
                Console.WriteLine(row["CUSTADDRESS"]);
                Console.WriteLine(row["PHONE"]);
                Console.WriteLine("-------------------");
            }
        }
    }
}
