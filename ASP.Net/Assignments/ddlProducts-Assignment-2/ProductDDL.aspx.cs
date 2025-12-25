using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_2
{
    public partial class ProductDDL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlProducts.Items.Add(new ListItem("Selecte Product"));
                ddlProducts.Items.Add(new ListItem("Laptop", "laptop"));
                ddlProducts.Items.Add(new ListItem("TV", "TV"));
                ddlProducts.Items.Add(new ListItem("Fridge", "fridge"));
                ddlProducts.Items.Add(new ListItem("Inverter","Inverter"));

            }
        }

        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlProducts.SelectedValue=="laptop")
            {
                ImageProduct.ImageUrl = "https://images6.alphacoders.com/991/991781.jpg";
            }
            else if(ddlProducts.SelectedValue=="TV")
            {
                ImageProduct.ImageUrl = "https://cdn.mos.cms.futurecdn.net/2WHPFPTfynDcuWKAjgYcvN.jpg";
            }
            else if(ddlProducts.SelectedValue=="fridge")
            {
                ImageProduct.ImageUrl = "https://initiative.co.in/wp-content/uploads/2022/09/Untitled-design-2022-10-07T184003.197.jpg";
            }
            else  
            {
                ImageProduct.ImageUrl = "https://thumbs.dreamstime.com/b/battery-inverter-charging-station-home-apartment-watts-volts-volts-v-battery-inverter-charging-station-home-339035944.jpg";
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(ddlProducts.SelectedValue=="laptop")
            {
                LabelPrice.Text = "Price: 70000";
            }
            else if(ddlProducts.SelectedValue=="TV")
            {
                LabelPrice.Text = "Price: 25000";
            }
            else if(ddlProducts.SelectedValue=="fridge")
            {
                LabelPrice.Text = "Price: 32000";
            }
            else if (ddlProducts.SelectedValue == "Inverter")
            {
                LabelPrice.Text = "Price: 40000";
            }
            else
            {
                LabelPrice.Text = "Please select a product";
            }
        }
    }
}