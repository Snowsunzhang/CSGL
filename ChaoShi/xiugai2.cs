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
    public partial class xiugai2 : Form
    {
        private DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public string name;
        public xiugai2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";

            str1 = textBox1.Text.Trim();
            str2 = textBox2.Text.Trim();
            str3 = textBox3.Text.Trim();
            str4 = textBox4.Text.Trim();

            var model = db.gys.FirstOrDefault(m => m.gname == name);
            if (model == null)
            {
                MessageBox.Show("该用户在数据库中不存在!");
                return;
            }

            model.gname = str1;
            model.glxr = str2;
            model.glxfs = str3;
            model.bz = str4;

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

        private void xiugai2_Load(object sender, EventArgs e)
        {
            var model = db.gys.FirstOrDefault(m => m.gname == name);

            if (model == null)
            {
                return;
            }
            textBox1.Text = model.gname;
            textBox2.Text = model.glxr;
            textBox3.Text = model.glxfs;
            textBox4.Text = model.bz;
           
        }
    }
}
