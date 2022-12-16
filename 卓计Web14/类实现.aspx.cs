using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using GROUP.Manage;


public partial class 类实现 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        BaseClass bc = new BaseClass();
        SqlDataReader dr = bc.readrow("select * from 用户 where 用户名='" + TextBox1.Text + "' and 密码 ='" + TextBox2.Text + "'");
        if (dr ==null)
        {
            Response.Write("<script>alert('用户名或密码错误')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";

        }
        else
        {
            Session["username"] = TextBox1.Text;//保存密码
            bool flage =false;
            while (dr.Read())
            {
                flage = (bool)dr[6];//转换bool,dr[6]查找第7个数据

            }
            if (flage==true)
                Response.Redirect("~/admin/adminindex.aspx");
            else
                Response.Redirect("~/userindex.aspx");

        }
    }
}