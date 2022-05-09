using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace write
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            //数据库有问题
            string str = @"Server= LAPTOP-11KDIIR8;DataBase=book;Integrated Security=True";//数据库连接字符串
            sc = new SqlConnection(str);//创建数据库连接对象
            sc.Open();//打开数据库
            return sc;//返回数据库连接对象
        }
        public SqlCommand Command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            
            return cmd;
        }
        public int Execute(string sql)//更新数据库
        {
            return Command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)//读取数据库
        {
            return Command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();//关闭数据库连接
        }
    }
}
