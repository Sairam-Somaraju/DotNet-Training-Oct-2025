using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_12_25
{
    internal class task_4
    {
        SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB; database=ADOnet; integrated security=true");
      
        public void CopyReaderToDataTable()
        {
            SqlCommand cmd = new SqlCommand("select  * from Department", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            Console.WriteLine("Department Records");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(dt.Rows[i][j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
