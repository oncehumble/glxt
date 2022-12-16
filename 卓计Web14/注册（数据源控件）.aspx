<%@ Page Language="C#" AutoEventWireup="true" CodeFile="注册（数据源控件）.aspx.cs" Inherits="注册_数据源控件_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：<asp:TextBox ID="TextBox1" runat="server" style="height: 23px"></asp:TextBox>
            <br />
            密码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            真实姓名：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            电话：<asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            <br />
            地址：<asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            <br />
            邮编：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="注册" />
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [用户] WHERE [用户名] = @用户名" InsertCommand="INSERT INTO [用户] ([用户名], [密码], [真实姓名], [电话], [地址], [邮编], [管理员标志]) VALUES (@用户名, @密码, @真实姓名, @电话, @地址, @邮编, @管理员标志)" OnInserted="SqlDataSource1_Inserted" SelectCommand="SELECT * FROM [用户]" UpdateCommand="UPDATE [用户] SET [密码] = @密码, [真实姓名] = @真实姓名, [电话] = @电话, [地址] = @地址, [邮编] = @邮编, [管理员标志] = @管理员标志 WHERE [用户名] = @用户名">
                <DeleteParameters>
                    <asp:Parameter Name="用户名" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="用户名" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" Name="密码" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox3" Name="真实姓名" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox4" Name="电话" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox5" Name="地址" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox6" Name="邮编" PropertyName="Text" Type="String" />
                    <asp:Parameter DefaultValue="false" Name="管理员标志" Type="Boolean" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="密码" Type="String" />
                    <asp:Parameter Name="真实姓名" Type="String" />
                    <asp:Parameter Name="电话" Type="String" />
                    <asp:Parameter Name="地址" Type="String" />
                    <asp:Parameter Name="邮编" Type="String" />
                    <asp:Parameter Name="管理员标志" Type="Boolean" />
                    <asp:Parameter Name="用户名" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
