using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ElectricityBoardBilling.ASP_Backend
{
    public static class DBHandler    
    {
        public static SqlConnection GetConnection()   
        {
            try
            {
                string conStr = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

                return new SqlConnection(conStr);
            }
            catch (Exception ex)
            {
                 throw new Exception("Database connection failed", ex);
            }
        }
    }
}
