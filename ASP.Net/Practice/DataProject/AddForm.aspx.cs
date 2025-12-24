using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataProject
{
    public partial class AddForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            con = new SqlConnection("Data source=(localdb)\\MSSQLLocalDB ; initial catalog=Infinite2025;" +
                "trusted_connection=true;");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Employees", con);
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
        }
    }
}