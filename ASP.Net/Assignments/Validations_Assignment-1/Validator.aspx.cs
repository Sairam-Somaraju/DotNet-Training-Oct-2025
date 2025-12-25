using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validations_Assignment
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Response.Write("WELCOME TO PROFILE....");
            }
            else
            {
                Response.Write("Please correct the details before submission");
            }
        }
    }
}