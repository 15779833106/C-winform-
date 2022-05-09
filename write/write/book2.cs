using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace write
{
    public partial class book2 : Form
    {
        string ID = "";
        public book2()
        {
            InitializeComponent();
        }
        public book2(string id, string name, string author)
        {
            InitializeComponent();
            ID=textBox1.Text = id;
            textBox2.Text = name;
            textBox3.Text = author;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = $"update t_book set bid='{textBox1.Text}',bname='{textBox2.Text}',bauthor='{textBox3.Text}'where bid='{ID}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            this.Close();
        }
    }
}
