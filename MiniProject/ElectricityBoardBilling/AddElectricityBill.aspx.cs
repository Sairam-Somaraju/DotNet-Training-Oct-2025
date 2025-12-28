using ElectricityBoardBilling.ASP_Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBoardBilling
{
    public partial class AddElectricityBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string cno = txtCno.Text.Trim();
                string name = txtName.Text.Trim();
                int units=Convert.ToInt32(txtUnits.Text.Trim());

                 if ( units < 0)
                {
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Text = "Given units is invalid";
                    return;
                }

                 ElectricityBills bill = new ElectricityBills(cno, name, units);

                 ElectricityBoard.CalculateBill(bill);

                // Add to database
                ElectricityBoard.AddBill(bill);

                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Text = $"Bill added successfully! Bill Amount: {bill.BillAmount}";

                // to clear all textbox values after form submission so the user can enter new data.
                txtCno.Text = txtName.Text = txtUnits.Text = "";
            }
            catch (FormatException ex)
            {
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = "Error: " + ex.Message;
            }
        }
    }
}