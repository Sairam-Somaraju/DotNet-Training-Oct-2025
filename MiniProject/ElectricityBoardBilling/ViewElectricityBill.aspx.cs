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
    public partial class ViewElectricityBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtCount.Text.Trim());

                if (n <= 0)
                {
                    lblMsg.Text = "Please enter a valid positive number.";
                    return;
                }
                SqlConnection con = DBHandler.GetConnection(); 
                try
                {
                    con.Open();
                    string query = "SELECT TOP (@n) * FROM ElectricityBill ORDER BY consumer_number DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", n);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);//used to fetch data from a database and store it into a DataTable.

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
                        lblMsg.Text = "No bills found.";
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

        protected void backk_Click(object sender, EventArgs e)
        {
            Response.Redirect("DashBoard.aspx");
        }

        protected void btnViewByConsumer_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBillByConsumer.aspx");

        }
    }
}