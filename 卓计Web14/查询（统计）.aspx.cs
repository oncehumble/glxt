using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class 查询_统计_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strcon = ConfigurationManager.ConnectionStrings["slcon"].ConnectionString;//获得连接字符串  
        SqlConnection con = new SqlConnection();
        con.ConnectionString = strcon;
        SqlCommand cmd = new SqlCommand(); //实例化cmd对象
        cmd.CommandText = "select * from 产品";
        cmd.Connection = con;
        con.Open();
        GridView1.DataSource = cmd.ExecuteReader();//设置数据源
        GridView1.DataBind();           //数据绑定
        con.Close();

        SqlCommand cmd2= new SqlCommand("select count(*) from 产品",con);//实例对象，select count 查询数量 
        con.Open();
        Label1.Text = cmd2.ExecuteNonQuery().ToString(); //实现增删改
        con.Close();
        
    }
}