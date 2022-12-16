using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 注册_数据源控件_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlDataSource1.SelectCommand += "where 用户名='" + TextBox1.Text + "'";
        if (((System.Data.DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty)).Count == 0) ;


        SqlDataSource1.Insert();




    }
    protected void SqlDataSource1_Inserted(object sender, SqlDataSourceStatusEventArgs e)
    {
        Response.Write("<script>alert('添加成功')</script>");
    }
}