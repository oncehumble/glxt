using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GROUP.Manage;

public partial class userindex : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        BaseClass bc = new BaseClass();
        int i = bc.execsql("delete from 订单 where 流水号=" + TextBox1.Text + " and 用户名='" + Session["username"].ToString()+"'");
        if (i == 0)
        {
            Response.Write("<script> alert)('删除成功')</script>");
        }
        else
            Response.Write("<script> alert)('删除失败')</script>");
    }
}