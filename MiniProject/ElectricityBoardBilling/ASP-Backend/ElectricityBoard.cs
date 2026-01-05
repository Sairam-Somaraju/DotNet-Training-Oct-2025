using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ElectricityBoardBilling.ASP_Backend
{
    public class ElectricityBoard
    {
        public static bool IsConsumerNumberExists(string consumerNumber)
        {
            SqlConnection con = DBHandler.GetConnection();

            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM ElectricityBill WHERE consumer_number = @cno";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cno", consumerNumber);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            finally
            {
                con.Close();
            }
        }

        public static void CalculateBill(ElectricityBills ebill)
        {
            int units = ebill.UnitsConsumed;
            double bill = 0;

            if (units <= 100)
            {
                bill = 0;
            }
            else if (units <= 300)
            {
                bill = (units - 100) * 1.5;
            }
            else if (units <= 600)
            {
                bill = 200 * 1.5 + (units - 300) * 3.5;
            }
            else if (units <= 1000)
            {
                bill = 200 * 1.5 + 300 * 3.5 + (units - 600) * 5.5;
            }
            else
                bill = 200 * 1.5 + 300 * 3.5 + 400 * 5.5 + (units - 1000) * 7.5;

            ebill.BillAmount = bill;
        }
        public static void AddBill(ElectricityBills ebill)
        {
            SqlConnection con = DBHandler.GetConnection(); // calls get connection() from DBHandler class to get a sql connection

            try
            {
                con.Open();
                string query = "INSERT INTO ElectricityBill " + "(consumer_number, consumer_name, units_consumed, bill_amount,BillDate) " + "VALUES (@cno, @name, @units, @bill,@date)";

                SqlCommand cmd = new SqlCommand(query, con); // to insert a new row in table
                cmd.Parameters.AddWithValue("@cno", ebill.ConsumerNumber); //sends the values to database 
                cmd.Parameters.AddWithValue("@name", ebill.ConsumerName);
                cmd.Parameters.AddWithValue("@units", ebill.UnitsConsumed);
                cmd.Parameters.AddWithValue("@bill", ebill.BillAmount);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Error adding bill: " + ex.Message);

            }
            finally
            {
                con.Close();
            }
        }
    }
}