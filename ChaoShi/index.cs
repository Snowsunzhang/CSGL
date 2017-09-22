using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChaoShi
{
    public partial class index : Form
    {
        public string name;
        public index()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void expandablePanel5_Click(object sender, EventArgs e)
        {

        }

        private void layoutControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX14_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "库存管理";
            kc form = new kc();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            tabControl1.TabPages.Add(tab);
            form.Dock = DockStyle.Fill;
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void index_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy-mm-dd");
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Login qh = new Login();
            qh.Show();
            this.Hide();
        }

        private void buttonX20_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click_1(object sender, EventArgs e)
        {
        }

        private void index_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            
            /*string str = DateTime.Now.ToString("MMddHmmss");
            MessageBox.Show(str);*/
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "进货信息";
            jhd  form = new jhd();
            form.name = name;
            form.TopLevel = false; //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "删除进货信息";
            Form2 form = new Form2();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "修改进货信息";
            Form2 form = new Form2();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX20_Click_1(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "查找进货信息";
            Form2 form = new Form2();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "售货单";
            shd form = new shd();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.name = name;
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "删除销售信息";
            Form2 form = new Form2();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX12_Click(object sender, EventArgs e)
        { TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "修改销售信息";
            Form2 form = new Form2();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();

        }

        private void buttonX23_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "退货信息";
            Form2 form = new Form2();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX24_Click(object sender, EventArgs e)
        {
            tjspxx tj = new tjspxx();
            tj.Show();
        }

        private void buttonX25_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "管理商品信息";
            glspxx form = new glspxx();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX26_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "盘点库存";
            kc form = new kc();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            tabControl1.TabPages.Add(tab);
            form.Dock = DockStyle.Fill;
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            xgmm xg = new xgmm();
            xg.name = name;
            xg.Show();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "客户管理";
            Form3 form = new Form3();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX15_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "查询进货单";
            cxjhd form = new cxjhd();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX16_Click(object sender, EventArgs e)
        {
            zdgl zd = new zdgl();
            zd.Show();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            tjygxx tj = new tjygxx();
            tj.Show();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "管理员工信息";
            Form2 form = new Form2();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX17_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "查询员工信息";
            chaxun form = new chaxun();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX22_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "查询供应商信息";
            cxgys form = new cxgys();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX18_Click(object sender, EventArgs e)
        {
            tjgys form = new tjgys();
            form.Show();
        }

        private void buttonX21_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "管理供应商信息";
            Form3 form = new Form3();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "查询进货单";
            cxjhd form = new cxjhd();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void buttonX8_Click_1(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Name = "bomo";
            tab.Text = "查询售货单";
            cxshd form = new cxshd();
            form.TopLevel = false;     //设置为非顶级控件
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            form.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xgmm xg = new xgmm();
            xg.name = name;
            xg.Show();
        }

        private void 添加员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tjygxx tj = new tjygxx();
            tj.Show();
        }

        private void 添加供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tjgys form = new tjgys();
            form.Show();
        }

        private void 添加商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tjspxx tj = new tjspxx();
            tj.Show();
        }
    }
}
