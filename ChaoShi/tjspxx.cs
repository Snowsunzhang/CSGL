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
    public partial class tjspxx : Form
    {
        DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public tjspxx()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            string str7 = "";
            string str8 = "";
            int a = 0;
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("商品编号不能为空!");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("商品名称不能为空!");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("生产日期不能为空!");
                textBox3.Focus();
                return;
            }
            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("商品类别不能为空!");
                textBox4.Focus();
                return;
            }
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("进货价不能为空!");
                textBox5.Focus();
                return;
            }
            if (textBox6.Text.Trim() == "")
            {
                MessageBox.Show("售货价不能为空!");
                textBox6.Focus();
                return;
            }
           
            if (textBox8.Text.Trim() == "")
            {
                MessageBox.Show("保质期至不能为空!");
                textBox8.Focus();
                return;
            }
            str1 = textBox1.Text.Trim();
            str2 = textBox2.Text.Trim();
            str3 = textBox3.Text.Trim();
            str4 = textBox4.Text.Trim();
            str5 = textBox5.Text.Trim();
            str6 = textBox6.Text.Trim();
            str7 = textBox7.Text.Trim();
            str8 = textBox8.Text.Trim();
            if (db.shangpins.Any(m => m.sno == str1) == true)
            {
                MessageBox.Show("商品编号重复!");
                textBox1.Focus();
                return;
            }

            DBCL2.shangpin model = new DBCL2.shangpin();

            model.sno = str1;
            model.sname = str2;
            model.sdate = str3;
            model.sleibie = str4;
            model.sjinjia = str5;
            model.sshoujia = str6;
            model.sdanwei = str7;
            model.sbaozhiqi = str8;
            model.shave = 0;

            try
            {
                db.shangpins.Add(model);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("添加失败!");
                return;
            }

            MessageBox.Show("添加成功!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tjspxx_Load(object sender, EventArgs e)
        {

        }
    }
}
