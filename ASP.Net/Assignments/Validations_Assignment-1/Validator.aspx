<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Validations_Assignment.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    body
    {
        background-color: #eef3f8;    
        font-family: Arial, sans-serif;
    }


    h3 
    {
        text-align: center;
        color: darkred;
    }
</style>

</head>
<body>
    <form id="form" runat="server">
        <div>

           <h3>INSERT YOUR DETAILS</h3> <br />
            <br />
            <br />
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtname" runat="server"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*  " ControlToValidate="txtname" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            FamilyName:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtfname" runat="server"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtfname" ErrorMessage="*  " ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtname" ControlToValidate="txtfname" ErrorMessage="Must be Differ from name" ForeColor="Red" Operator="NotEqual"></asp:CompareValidator>
            <br />
            <br />
            Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtadd" runat="server"></asp:TextBox>&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtadd" ErrorMessage="*  " ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtadd" ErrorMessage="Required Atleast two chars" ForeColor="Red" ValidationExpression="^.{2,}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtcity" ErrorMessage="*  " ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtcity" ErrorMessage="Required Atleast two chars" ForeColor="Red" ValidationExpression="^.{2,}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            Zip Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtzcode" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*  " ControlToValidate="txtzcode" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtzcode" ErrorMessage="(xxxxxx)" ForeColor="Red" ValidationExpression="^[1-9][0-9]{5}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtphn" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*  " ControlToValidate="txtphn" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtphn" ErrorMessage="(xx-xxxxxxxxxx)" ForeColor="Red" ValidationExpression="^(?:\+91|91)?[6-9][0-9]{9}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            E-Mail:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*  " ControlToValidate="txtmail" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtmail" ErrorMessage="example@example" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;<asp:Button ID="Button1" runat="server" Text="Check" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <br /><br /><br />
 
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Validation Summary" ShowMessageBox="True" />
 
        </div>
    </form>
     
</body>
</html>
