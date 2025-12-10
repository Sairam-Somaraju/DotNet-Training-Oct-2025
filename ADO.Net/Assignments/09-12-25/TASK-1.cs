using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _09_12_25
{
    internal class TASK_1
    {
        SqlConnection con=new SqlConnection("server=(localdb)\\MSSQLLocalDB; database=ADOnet; integrated security=true");
        DataSet ds = new DataSet();
        SqlDataAdapter daEmp;
        SqlDataAdapter daDept;

        public void ShowAll()
        {
            daEmp = new SqlDataAdapter("select * from Employee", con);
            daEmp.Fill(ds,"Employee");

            daDept = new SqlDataAdapter("select * from Department",con);
            daDept.Fill(ds,"Department");

            Console.WriteLine("--Employee Details--");

            DataTable dt1 = ds.Tables["Employee"];
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                for (int j = 0; j < dt1.Columns.Count; j++)
                {
                    Console.Write(dt1.Rows[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Department Records");
            DataTable dt2= ds.Tables["Department"];
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                for (int j = 0; j < dt2.Columns.Count; j++)
                {
                    Console.Write(dt2.Rows[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
