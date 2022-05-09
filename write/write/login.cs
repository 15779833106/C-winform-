using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
/**
 * 若出现另一个进程还在执行的情况时，此时就要去任务管理器找到该进程将其关闭即可
 * */


namespace write
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string psw = textBox2.Text;
            string constr= "Server= LAPTOP-11KDIIR8;DataBase=book;Integrated Security=True";
            // 建立SqlConnection对象
            SqlConnection con = new SqlConnection(constr);
            // 打开连接
            con.Open();
            // 指定SQL语句
            SqlCommand com = new SqlCommand("select name,psw from admin where name='" + name + "' and psw='" + psw + "'", con);
            // 建立SqlDataAdapter和DataSet对象
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            int n = da.Fill(ds, "admin");
            if (n != 0)
            {
                MessageBox.Show("登录成功！", "提示");
                
                login1 w1 = new login1();
               this.Hide();
                       w1.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("用户名或密码错误或为空，请重新输入！", "提示");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            con.Close();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
