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
    public partial class xiugai : Form
    {
        private DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public string name;
        public xiugai()
        {
            InitializeComponent();
        }

        private void xiugai_Load(object sender, EventArgs e)
        {
            var model = db.users.FirstOrDefault(m => m.uname == name);

            if (model == null)
            {
                return;
            }
            textBox1.Text = model.uname;
            textBox2.Text = model.usex;
            textBox3.Text = model.uage;
            textBox4.Text = model.uphone;
            textBox5.Text = model.uadress;
            textBox6.Text = model.ubeizhu;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";

            str1 = textBox1.Text.Trim();
            str2 = textBox2.Text.Trim();
            str3 = textBox3.Text.Trim();
            str4 = textBox4.Text.Trim();
            str5 = textBox5.Text.Trim();
            str6 = textBox6.Text.Trim();

            var model = db.users.FirstOrDefault(m => m.uname == name);
            if (model == null)
            {
                MessageBox.Show("该用户在数据库中不存在!");
                return;
            }

            model.uname = str1;
            model.usex = str2;
            model.uage = str3;
            model.uphone = str4;
            model.uadress= str5;
            model.ubeizhu= str6;

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("编辑失败!");
                return;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
