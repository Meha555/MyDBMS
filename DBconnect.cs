using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDBMS
{
    class DBconnect
    {
        SqlConnection sc;
        public SqlConnection connect()//连接数据库
        {
            string str = @"Data Source=localhost;Initial Catalog=logisticDB;Integrated Security=True";
            //服务器名称 数据库名 参数
            sc = new SqlConnection(str);//创建数据库连接对象
            sc.Open();//打开数据库
            return sc;//返回数据库连接对象
        }
        public SqlCommand command(string sql)//数据库SQL语句操作
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)//数据库更新操作，适用于修改数据但不返回内容的操作
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)//数据库读取操作
        {
            return command(sql).ExecuteReader();
        }
        public void DBclose()//关闭数据库
        {
            sc.Close();
        }
    }
}
