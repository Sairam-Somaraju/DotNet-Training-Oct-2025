using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_12_25
{
    internal class task_5
    {
        SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB; database=ADOnet; integrated security=true");
         public void MergeCustomersandOrders()
        {
            DataSet ds1=new DataSet();
            DataSet ds2 = new DataSet();

            SqlDataAdapter daemp = new SqlDataAdapter("select * from Employee", con);
            daemp.Fill(ds1,"Employee");

            SqlDataAdapter dadep = new SqlDataAdapter("select * from Department", con);
            dadep.Fill(ds2,"Department");

            ds1.Merge(ds2 );

            Console.WriteLine("Employee Details");
            DataTable dataTable=ds1.Tables["Employee"];

            for(int i=0;i<dataTable.Rows.Count;i++)
            {
                for(int j=0;j<dataTable.Columns.Count;j++)
                {
                    Console.Write(dataTable.Rows[i][j]+"\t");
                }
                Console.WriteLine();

            }

            Console.WriteLine("Department Details");
            DataTable dataTable2 = ds1.Tables["Department"];

            for (int i = 0; i < dataTable2.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable2.Columns.Count; j++)
                {
                    Console.Write(dataTable2.Rows[i][j]+"\t");
                }
                Console.WriteLine();

            }

        }
    }
}
