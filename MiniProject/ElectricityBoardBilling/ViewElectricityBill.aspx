<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewElectricityBill.aspx.cs" Inherits="ElectricityBoardBilling.ViewElectricityBill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Details</title>
    <style>
 body {
    font-family: "Segoe UI", Arial, sans-serif;
    background-color: #f4f6f9;
    margin: 0;
    padding: 0;
    height: 100vh;

    display: flex;
    justify-content: center;
    align-items: center;
}

form {
    margin: 0;
}

.card {
    background-color: #ffffff;
    padding: 30px 35px;
    width: 650px;
    border-radius: 10px;
    box-shadow: 0 8px 25px rgba(0, 0, 0, 0.12);
}

h3 {
    text-align: center;
    color: #1e3a8a;
    margin-bottom: 20px;
}

 input[type="text"] {
    padding: 8px 10px;
    width: 250px;
    border-radius: 6px;
    border: 1px solid #cbd5e1;
    font-size: 14px;
}

input[type="text"]:focus {
    outline: none;
    border-color: #2563eb;
    box-shadow: 0 0 4px rgba(37, 99, 235, 0.3);
}

 input[type="submit"] {
    background-color: #2563eb;
    color: white;
    border: none;
    padding: 9px 18px;
    font-size: 14px;
    border-radius: 6px;
    cursor: pointer;
    transition: background-color 0.3s ease;
}

input[type="submit"]:hover {
    background-color: #1e40af;
}

 table {
    width: 100%;
    border-collapse: collapse;
    margin-top: 15px;
}

th {
    background-color: #1e3a8a;
    color: white;
    padding: 10px;
    text-align: left;
}

td {
    padding: 9px;
    border-bottom: 1px solid #e5e7eb;
}

tr:nth-child(even) {
    background-color: #f8fafc;
}

tr:hover {
    background-color: #e0e7ff;
}

/* Validation & message */
span {
    font-size: 13px;
}

#lblMsg {
    display: block;
    text-align: center;
    margin-top: 10px;
    font-weight: 600;
}
</style>
 
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h3>View Last N Electricity Bills</h3>

            Enter Number of Bills:
            <asp:TextBox ID="txtCount" runat="server" />

            <asp:RequiredFieldValidator ID="rfvCount" runat="server"
                ControlToValidate="txtCount"
                ErrorMessage="Required"
                ForeColor="Red" />

            <br /><br />

            <asp:Button ID="btnView" runat="server"
                Text="View Bills"
                OnClick="btnView_Click" />

            <br /><br />

            <asp:GridView ID="gvBills" runat="server" AutoGenerateColumns="false" BorderWidth="1">
                <Columns>
                    <asp:BoundField DataField="consumer_number" HeaderText="Consumer Number" />
                    <asp:BoundField DataField="consumer_name" HeaderText="Consumer Name" />
                    <asp:BoundField DataField="units_consumed" HeaderText="Units Consumed" />
                    <asp:BoundField DataField="bill_amount" HeaderText="Bill Amount" />
                </Columns>
            </asp:GridView>

            <br />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
