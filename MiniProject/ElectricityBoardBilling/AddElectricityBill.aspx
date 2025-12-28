<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddElectricityBill.aspx.cs" Inherits="ElectricityBoardBilling.AddElectricityBill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title>Add Bill</title>
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
    padding: 30px 40px;
    width: 420px;
    border-radius: 10px;
    box-shadow: 0 8px 20px rgba(0, 0, 0, 0.1);
}

h3 {
    text-align: center;
    color: #1e3a8a;
    margin-bottom: 25px;
}
#btnAdd
{
    color:forestgreen;
}

</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
    <h3>Add Electricity Bill</h3>

    Consumer Number:
    <asp:TextBox ID="txtCno" runat="server" />
     
    <asp:RequiredFieldValidator ID="rfvCno" runat="server" ControlToValidate="txtCno" ErrorMessage="Consumer Number is required" ForeColor="Red" />

    <asp:RegularExpressionValidator ID="revCno" runat="server" ControlToValidate="txtCno" ErrorMessage="Consumer Number must start with EB" ValidationExpression="^EB.*" ForeColor="Red" />
    <br /><br />

    Consumer Name:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtName" runat="server" />

    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Consumer Name is required" ForeColor="Red" />
    <br /><br />

    Units Consumed:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtUnits" runat="server" />

    <asp:RequiredFieldValidator ID="rfvUnits" runat="server" ControlToValidate="txtUnits" ErrorMessage ="Units Consumed is required" ForeColor="Red" />

    <asp:RangeValidator ID="rvUnits" runat="server" ControlToValidate="txtUnits" MinimumValue="1" MaximumValue="100000" Type="Integer" ErrorMessage="Units must be a positive number" ForeColor="Red" />
    <br /><br />
    
    <asp:Button ID="btnAdd" runat="server"  Text="Add Bill" OnClick="btnAdd_Click" />

    <br /><br />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Green" />
</div>
    </form>
</body>
</html>
