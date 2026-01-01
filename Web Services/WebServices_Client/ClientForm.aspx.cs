 using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServices_Client
{
    public partial class ClientForm : System.Web.UI.Page
    {
        Web_Infinite.WebServiceSoapClient client =
           new Web_Infinite.WebServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblstatus.Text = client.HelloWorld();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblstatus.Text = client.SayHello();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            lblstatus.Text = client.Squareroot(Convert.ToSingle(txtfnum.Text)).ToString();
        }
    }
}