<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBillByConsumer.aspx.cs" Inherits="ElectricityBoardBilling.ViewBillByConsumer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
 body {
    margin: 0;
    padding: 0;
    height: 100vh;
    background: linear-gradient(135deg, #e0f2fe, #f8fafc);
    font-family: 'Segoe UI', Tahoma, Arial, sans-serif;

    display: flex;
    justify-content: center;
    align-items: center;
}

 .card {
    width: 800px;
    background: #ffffff;
    padding: 30px 35px;
    border-radius: 14px;
    box-shadow: 0 15px 40px rgba(0, 0, 0, 0.15);
}

 .card h3 {
    text-align: center;
    margin-bottom: 25px;
    color: #1e3a8a;
    font-size: 22px;
    font-weight: 600;
}

 input[type="text"] {
    width: 260px;
    padding: 9px 12px;
    border-radius: 8px;
    border: 1px solid #cbd5e1;
    font-size: 14px;
}

input[type="text"]:focus {
    outline: none;
    border-color: #2563eb;
    box-shadow: 0 0 6px rgba(37, 99, 235, 0.3);
}

 input[type="submit"],
button,
asp\:Button {
    padding: 9px 18px;
    border-radius: 8px;
    border: none;
    cursor: pointer;
    font-size: 14px;
    font-weight: 600;
    transition: 0.3s;
}

 #btnSearch {
    background-color: #2563eb;
    color: white;
}

#btnSearch:hover {
    background-color: #1e40af;
}

 #Button1 {
    background-color: seagreen;
    color: #374151;
}

#Button1:hover {
    background-color: #d1d5db;
}

 table {
    width: 100%;
    border-collapse: collapse;
    margin-top: 25px;
    font-size: 14px;
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

 #lblMsg {
    display: block;
    text-align: center;
    margin-top: 15px;
    font-weight: 600;
}

 @media (max-width: 900px) {
    .card {
        width: 95%;
    }
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="card">

        <h3>Search Bills by Consumer Number</h3>

        Consumer Number:
        <asp:TextBox ID="txtConsumerNo" runat="server" />
                <br /><br />&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server"
            Text="Search"
            OnClick="btnSearch_Click" />
         <br /><br />

        <asp:GridView ID="gvBills" runat="server"
            AutoGenerateColumns="false"
            Width="100%">

            <Columns>
                <asp:BoundField DataField="consumer_number" HeaderText="Consumer No" />
                <asp:BoundField DataField="consumer_name" HeaderText="Name" />
                <asp:BoundField DataField="units_consumed" HeaderText="Units" />

                <asp:BoundField DataField="bill_amount" HeaderText="Bill Amount" DataFormatString="{0:C}" />

                <asp:BoundField DataField="BillDate" HeaderText="Bill Date" DataFormatString="{0:dd-MM-yyyy}" HtmlEncode="false"> <ItemStyle Wrap="false" Width="120px" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>

        <br />
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />

    </div>
        </div>
    </form>
</body>
</html>
