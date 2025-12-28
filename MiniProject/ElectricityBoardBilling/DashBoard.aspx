<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="ElectricityBoardBilling.DashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin DashBoard</title>
   <style>
      body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: #f0f4f8;  
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .dashboard-container {
            background-color: white;
            padding: 40px;
            border-radius: 12px;
            box-shadow: 0 5px 15px rgba(0,0,0,0.1);
            text-align: center;
            width: 350px;
        }

        .dashboard-container h1 {
            color: #333;
            margin-bottom: 15px;
            font-size: 24px;
        }

        .dashboard-container p {
            color: #555;
            font-size: 14px;
            margin-bottom: 30px;
        }

        .dashboard-btn {
            display: block;
            width: 100%;
            padding: 12px 0;
            margin: 10px 0;
            font-size: 16px;
            color: white;
            border: none;
            border-radius: 8px;
            cursor: pointer;
            transition: 0.3s;
        }

        #btnAddBill {
            background-color: #4CAF50; /* Green */
        }

        #btnAddBill:hover {
            background-color: #45a049;
        }

        #btnViewBill {
            background-color: #2196F3; /* Blue */
        }

        #btnViewBill:hover {
            background-color: #1e88e5;
        }

        .footer-label {
            margin-top: 20px;
            font-size: 12px;
            color: #777;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="dashboard-container">
            
            <h1>Electricity Board Billing System</h1>
 
            <asp:Button ID="btnAddBill" runat="server" Text="Add New Bill" CssClass="dashboard-btn" OnClick="btnAddBill_Click" />
            <asp:Button ID="btnViewBill" runat="server" Text="View Bills" CssClass="dashboard-btn" OnClick="btnViewBill_Click" />

        </div>
    </form>
</body>
</html>
