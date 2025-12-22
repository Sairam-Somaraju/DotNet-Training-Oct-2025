using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}

        //protected void Textbox_TextChanged(object sender, EventArgs e)
        //{
             
        //}
        protected void BLnClick(object sender, EventArgs e)
        {
            TextBox1.Text = "Sairam";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox1.Text = "Welcome to ASP.Net";
        }
    }
}