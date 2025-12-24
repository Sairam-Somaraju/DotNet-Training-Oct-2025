<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ssss.aspx.cs" Inherits="DataProject.ssss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="custid" HeaderText="custid" SortExpression="custid" />
                    <asp:BoundField DataField="orderid" HeaderText="orderid" SortExpression="orderid" />
                    <asp:BoundField DataField="orderdate" HeaderText="orderdate" SortExpression="orderdate" />
                    <asp:BoundField DataField="products" HeaderText="products" SortExpression="products" />
                    <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                    <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Infinite2025ConnectionString3 %>" ProviderName="<%$ ConnectionStrings:Infinite2025ConnectionString3.ProviderName %>" SelectCommand="SELECT * FROM [Orders]"></asp:SqlDataSource>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="orderid" HeaderText="orderid" SortExpression="orderid" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:BoundField DataField="products" HeaderText="products" SortExpression="products" />
            </Fields>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Infinite2025ConnectionString3 %>" SelectCommand="SELECT [orderid], [price], [products] FROM [Orders] WHERE ([custid] = @custid)">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="custid" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
