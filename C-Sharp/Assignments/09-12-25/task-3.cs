using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_12_25
{
    internal class task_3
    {
        SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB; database=ADOnet; integrated security=true");

        //DataSet ds = new DataSet();
        SqlDataAdapter da;
        

        public void CountTables()
        {
            DataTable dt = new DataTable();

            da = new SqlDataAdapter(
                "SELECT COUNT(*) AS TotalTables FROM sys.tables", con);

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine(
                    "The Total Number of Tables in Database : " +
                    dt.Rows[0]["TotalTables"]);
            }
            else
            {
                Console.WriteLine("No data returned from database.");
            }

         }
    }
}
