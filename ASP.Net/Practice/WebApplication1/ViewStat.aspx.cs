using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewStat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               
        }

        protected void txtusername_TextChanged(object sender, EventArgs e)
        {
            ViewState["uname"]=txtusername.Text;
            ViewState["pass"]= txtpass.Text;
            txtusername.Text = "";
            txtpass.Text = string.Empty;
        }

        protected void txtpass_TextChanged(object sender, EventArgs e)
        {
            string u= ViewState["uname"].ToString();
            string p = ViewState["pass"].ToString();
            Response.Write("User Name is " + u + " and password is " + p);
        }
    }
}