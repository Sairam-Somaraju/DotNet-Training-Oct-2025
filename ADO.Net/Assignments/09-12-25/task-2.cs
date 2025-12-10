using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_12_25
{
    internal class task_2
    {
        SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB; database=ADOnet; integrated security=true");
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        public void FilterAndSortEmployees()
        {
            da = new SqlDataAdapter("Select * from Employee",con);
            da.Fill(ds,"Employee");
            DataTable dt=ds.Tables["Employee"];

            DataView dv = new DataView(dt);
            dv.RowFilter = "Salary>47000 And DeptID=10 and EmpName like 'M%'";
            dv.Sort = "EmpName asc";

            Console.WriteLine("Filtered and Sorted Employess");
            for (int i = 0; i < dv.Count; i++)
            {
                for (int j = 0; j < dv.Table.Columns.Count; j++)
                {
                    Console.Write(dv[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
