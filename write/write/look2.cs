using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//命名空间
using System.Drawing.Text;
using System.Collections;
using System.IO;

namespace write
{
    public partial class look2 : Form
    {
        public look2()
        {
            InitializeComponent();
        }

       
        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //打开文件

            //新建一个打开文件的对话框
            //创建一个筛选器
            openFileDialog1.Filter = ("文本文档(*.txt)|*.txt");
            //判断用户点击的是打开按钮还是取消按钮
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //获取文件路径
                string path = openFileDialog1.FileName;
                //通用编码utf-8
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                //读取文档中的数据流
                string text = sr.ReadToEnd();
                richTextBox1.Text = text;
                //将打开的文件路径写到当前窗体的text属性中
                this.Text = path;

                sr.Close();

            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //没隔一段时间更新下时间信息
            toolStripLabel1.Text = "当前时间：" + DateTime.Now.ToLongTimeString().ToString();
        }

        private void look3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
