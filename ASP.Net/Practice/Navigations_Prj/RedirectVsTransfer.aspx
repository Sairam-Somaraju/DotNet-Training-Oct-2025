<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedirectVsTransfer.aspx.cs" Inherits="WebApplication2.RedirectVsTransfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         
            Name:&nbsp;
            <asp:TextBox ID="Txtname" runat="server"></asp:TextBox>
         <br />
        <br />
             
             E-Mail:<asp:TextBox ID="Txtmail" runat="server"></asp:TextBox>
            <br />
         <div>
             <br />
             <asp:Button ID="Button1" runat="server" Text="Get Resource" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
