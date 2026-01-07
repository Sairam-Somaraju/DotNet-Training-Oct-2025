using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBoardBilling
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void lnkDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DashBoard.aspx");
        }

        protected void lnkAddBill_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddElectricityBill.aspx");
        }

        protected void lnkViewBill_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewElectricityBill.aspx");
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            // Optional: Clear session or redirect to login
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}