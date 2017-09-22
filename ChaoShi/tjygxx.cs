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
    public partial class tjygxx : Form
    {
        private DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public tjygxx()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1, str2, str3, str4, str5, str6, str7;
            str1 = ""; str2 = ""; str3 = ""; str4 = ""; str5 = ""; str6 = ""; str7 = "";
            str1 = textBox1.Text.Trim();
            str2 = textBox2.Text.Trim();
            str3 = textBox3.Text.Trim();
            str4 = textBox4.Text.Trim();
            str5 = textBox5.Text.Trim();
            str6 = textBox6.Text.Trim();
            str7 = textBox7.Text.Trim();
            if (db.users.Any(m => m.uname == str1) == true)
            {
                MessageBox.Show("用户名重复!");
                textBox1.Focus();
                return;
            }
            DBCL2.user model = new DBCL2.user();
            model.uname = str1;
            model.usex = str2;
            model.uage = str3;
            model.uphone = str4;
            model.uadress = str5;
            model.ubeizhu = str6;
            model.upassword = str7;
            try
            {
                db.users.Add(model);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("添加失败!");
                return;
            }

            MessageBox.Show("添加成功!");
        }

        private void tjygxx_Load(object sender, EventArgs e)
        {

        }
    }
}
