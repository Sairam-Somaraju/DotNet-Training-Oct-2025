using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElectricityBoardBilling.ASP_Backend
{
    public class ElectricityBillRepository
    {
        public static DataTable GetBillsByConsumer(string consumerNumber)
        {
            SqlConnection con = DBHandler.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                con.Open();

                string query = @"SELECT consumer_number,
                                        consumer_name,
                                        units_consumed,
                                        bill_amount,
                                        BillDate
                                 FROM ElectricityBill
                                 WHERE consumer_number = @cno
                                 ORDER BY BillDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cno", consumerNumber);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
    }
}