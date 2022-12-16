<%@ Page Language="C#" AutoEventWireup="true" CodeFile="查询(统计).aspx.cs" Inherits="查询_统计_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [产品图片], [产品价格], [产品名称], [流水号] FROM [产品]"></asp:SqlDataSource>
            <br />
            请选择类别<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="产品类别" DataValueField="产品类别">
            </asp:DropDownList>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="流水号" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="产品图片" HeaderText="产品图片" SortExpression="产品图片" />
                    <asp:BoundField DataField="产品价格" HeaderText="产品价格" SortExpression="产品价格" />
                    <asp:BoundField DataField="产品名称" HeaderText="产品名称" SortExpression="产品名称" />
                    <asp:BoundField DataField="流水号" HeaderText="流水号" InsertVisible="False" ReadOnly="True" SortExpression="流水号" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [产品类别] FROM [产品]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
