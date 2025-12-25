<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDDL.aspx.cs" Inherits="Assignment_2.ProductDDL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Drop Down Products </title>
    <style>
        #LabelPrice
        {
            color:green;
        }
        #ImageProduct
        {
             Width:200px;
             Height:200px;
        }
        #ddlProducts
        {
            color:darkred;
        }
        #Button1
        {
            color:darkred;
        }
        body
        {
            background-color: #e8f5e9;
        }
        h3
        {
            color:darkred;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h3>PRODUCT LIST</h3>
            <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="ImageProduct" runat="server" />
            <br />
            <br />

            <br />
            <asp:Button ID="Button1" runat="server" Text="GetPrice" OnClick="Button1_Click" />

            <br />
            <br />
            <br />
            <asp:Label ID="LabelPrice" runat="server" Font-Bold="true" ></asp:Label>

        </div>
    </form>
</body>
</html>
