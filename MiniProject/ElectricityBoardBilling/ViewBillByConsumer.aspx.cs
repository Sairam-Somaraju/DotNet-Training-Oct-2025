using ElectricityBoardBilling.ASP_Backend;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBoardBilling
{
    public partial class ViewBillByConsumer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string cno = txtConsumerNo.Text.Trim(); // Consumer Number input
                if (string.IsNullOrEmpty(cno))
                {
                    lblMsg.Text = "Enter consumer number";
                    return;
                }

                SqlConnection con = DBHandler.GetConnection();
                try
                {
                    con.Open();
                    string query = "SELECT * FROM ElectricityBill WHERE consumer_number=@cno ORDER BY BillDate DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cno", cno);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        gvBills.DataSource = dt;
                        gvBills.DataBind();
                        lblMsg.Text = "";
                    }
                    else
                    {
                        gvBills.DataSource = null;
                        gvBills.DataBind();
                        lblMsg.Text = "No bills found for this consumer";
                    }
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewElectricityBill.aspx");
        }
    }
}