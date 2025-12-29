using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class RedirectVsTransfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Context.Items.Add("Name", Txtname.Text);
            Context.Items.Add("Email",Txtmail.Text);

            Response.Write(Context.Items["Name"].ToString() + " " + Context.Items["Email"].ToString());

            //Navigation options
            //1.redirect
            //Response.Redirect("Page1.aspx"); //this resource is in the same application and server
            Response.Redirect("https://www.google.com");// resource in someother server

            //2.Server.transfer
            // Server.Transfer("Page1.aspx");

            // Server.Transfer("https://www.goo.com"); //Can't possible

            Server.Execute("Page1.aspx");

            //Response.Write("I am Back"); // comes back after the executing the second page

            // continue with the first 
        }
        
    }
}