using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

/// <summary>
///BaseClass 的摘要说明
/// </summary>



namespace GROUP.Manage
{//自定义命名空间开始

    public class BaseClass : System.Web.UI.Page
    {//自定义类开始
        String strConn;//类变量

        public BaseClass()//构造函数
        {
            strConn = ConfigurationManager.ConnectionStrings["slcon"].ConnectionString;
        }

        public SqlDataReader readrow(String sql)//readrow 执行sql语句
        {

            SqlConnection Conn = new SqlConnection(strConn);
            Conn.Open();
            SqlCommand Comm = new SqlCommand(sql, Conn);
            SqlDataReader Reader = Comm.ExecuteReader();
            if (Reader.Read())
            {
                Comm.Dispose();
                return Reader;
            }
            else
            {
                Comm.Dispose();
                return null;
            }

        }

        //读某一行中某一字段的值
        public string Readstr(String strSql, int flag)
        {
            DataSet ds = new DataSet();//创建一个数据集ds
            String str;

            SqlConnection Conn = new SqlConnection(strConn);//定义新的数据连接控件并初始化

            Conn.Open();//打开连接

            SqlDataAdapter Cmd = new SqlDataAdapter(strSql, Conn);//定义并初始化数据适配器
            Cmd.Fill(ds);								//将数据适配器中的数据填充到数据集ds中

            str = ds.Tables[0].Rows[0].ItemArray[flag].ToString();
            Conn.Close();//关闭连接
            return str;
        }

        //执行非查询Sql语句
        public int execsql(String strSql)
        {
            SqlConnection Conn = new SqlConnection(strConn);//定义新的数据连接控件并初始化

            SqlCommand Comm = new SqlCommand(strSql, Conn);

            Conn.Open();//打开连接

            return (Comm.ExecuteNonQuery());//执行命令
            Conn.Close();//关闭连接

        }

        //读写数据表--DataTable
        public DataTable ReadTable(String strSql)
        {
            DataTable dt = new DataTable();//创建一个数据表dt
            SqlConnection Conn = new SqlConnection(strConn);//定义新的数据连接控件并初始化
            Conn.Open();//打开连接
            SqlDataAdapter Cmd = new SqlDataAdapter(strSql, Conn);//定义并初始化数据适配器
            Cmd.Fill(dt);								//将数据适配器中的数据填充到数据集dt中
            Conn.Close();//关闭连接
            return dt;
        }

        //读写数据集--DataSet
        public DataSet ReadDataSet(String strSql)
        {
            DataSet ds = new DataSet();//创建一个数据集ds
            SqlConnection Conn = new SqlConnection(strConn);//定义新的数据连接控件并初始化
            Conn.Open();//打开连接
            SqlDataAdapter Cmd = new SqlDataAdapter(strSql, Conn);//定义并初始化数据适配器
            Cmd.Fill(ds);								//将数据适配器中的数据填充到数据集ds中
            Conn.Close();//关闭连接
            return ds;
        }

        public DataSet GetDataSet(String strSql, String tableName)
        {
            DataSet ds = new DataSet();//创建一个数据集ds
            SqlConnection Conn = new SqlConnection(strConn);//定义新的数据连接控件并初始化
            Conn.Open();//打开连接
            SqlDataAdapter Cmd = new SqlDataAdapter(strSql, Conn);//定义并初始化数据适配器
            Cmd.Fill(ds, tableName);								//将数据适配器中的数据填充到数据集ds中
            Conn.Close();//关闭连接
            return ds;

        }

       

    }//类定义结束
}//命名空间结束