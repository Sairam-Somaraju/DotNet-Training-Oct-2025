using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBoardBilling
{
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddBill_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddElectricityBill.aspx");

        }

        protected void btnViewBill_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewElectricityBill.aspx");

        }
    }
}