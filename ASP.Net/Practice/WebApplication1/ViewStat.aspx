<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStat.aspx.cs" Inherits="WebApplication1.ViewStat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblusername" runat="server" Text="User Name"></asp:Label>
            &nbsp : &nbsp;&nbsp;&nbsp;&nbsp
            <asp:TextBox ID="txtusername" runat="server" OnTextChanged="txtusername_TextChanged"  ></asp:TextBox>
                                    <br /><br />

             <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
                                     &nbsp :&nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="txtpass" runat="server" OnTextChanged="txtpass_TextChanged"></asp:TextBox>
            <br /><br />
            <asp:Button ID="BtnStore" runat="server" Text="Store Data" />
                                    &nbsp;&nbsp;&nbsp

            <asp:Button ID="BtnLoad" runat="server" Text="Load Data" />
 
            <br />
            <p>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
</p>
        </div>
    </form>
</body>
</html>
