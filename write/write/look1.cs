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
    public partial class look1 : Form
    {
        public look1()
        {
            InitializeComponent();
        }
        public void Table()
        {


            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            book1 b1 = new book1();
            b1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
               
                book2 b2 = new book2(id, name, author);

                b2.ShowDialog();
                Table();//刷新数据
            }
            catch
            {
                MessageBox.Show("错误");

            }
            
        }

        private void look1_Load(object sender, EventArgs e)
        {

            //this.WindowState = FormWindowState.Maximized;
            Table();
        }
        //删除按钮
        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取书号

                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql =$"delete from t_book where bid='{id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败" + sql);

                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中要删除的行", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
        }
    }
}
