using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomValidations
{
    public partial class CustomForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome to Voter Application..");
        }

        

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(args.Value=="")
            {
                args.IsValid = false;
            }
            else
            {
                if ((Convert.ToInt32(args.Value) > 18))
                {
                    
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblmsg.Text = "Eligible for Vote...";
                lblmsg.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblmsg.Text = "Not Eligible for vote";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}