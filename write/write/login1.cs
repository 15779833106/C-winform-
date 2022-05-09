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
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }
        //新建
        private void ToolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            //实例化一个子窗体对象
            write1 w1 = new write1();
            //设置子窗体的父窗体
            w1.MdiParent = this;
            //打开子窗体
            w1.Show();
        }
        //关闭
        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            Form f = this.ActiveMdiChild;
            f.Close();
        }
        //关闭全部

        private void ToolStripMenuItemCloseAll_Click(object sender, EventArgs e)
        {
            //this.MdiChildren获取父窗体的子窗体的集合
            foreach(Form form in this.MdiChildren)
            {
                Form f = this.ActiveMdiChild;
                f.Close();
            }
        }
        //退出
        private void ToolStripMenuItemOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //实例化一个子窗体对象
            paint p1 = new paint();
            //设置子窗体的父窗体
            p1.MdiParent = this;
            //打开子窗体
            p1.Show();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = this.ActiveMdiChild;
            f.Close();
        }

        private void 关闭全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //this.MdiChildren获取父窗体的子窗体的集合
            foreach (Form form in this.MdiChildren)
            {
                Form f = this.ActiveMdiChild;
                f.Close();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //实例化一个子窗体对象
            look2 l3 = new look2();
            //设置子窗体的父窗体
            l3.MdiParent = this;
            //打开子窗体
           
            l3.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://baidu.com/ ");
        }

        private void 退出ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 关于此创作设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化一个子窗体对象
            about a = new about();
            //设置子窗体的父窗体
            a.MdiParent = this;
            //打开子窗体

            a.Show();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cn.bing.com/search?q=%E8%8E%B7%E5%8F%96%E6%9C%89%E5%85%B3+windows+10+%E4%B8%AD%E7%9A%84%E8%AE%B0%E4%BA%8B%E6%9C%AC%E7%9A%84%E5%B8%AE%E5%8A%A9&filters=guid:%224466414-zh-hans-dia%22%20lang:%22zh-hans%22&form=T00032&ocid=HelpPane-BingIA ");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            look1 l1 = new look1();
            l1.MdiParent = this;
            l1.Show();
            //l1.Close();
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }
    }
}
