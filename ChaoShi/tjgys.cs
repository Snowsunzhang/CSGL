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
    public partial class tjgys : Form
    {
        DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public tjgys()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1, str2, str3, str4;
            str1 = ""; str2 = ""; str3 = ""; str4 = ""; 
            str1 = textBox1.Text.Trim();
            str2 = textBox2.Text.Trim();
            str3 = textBox3.Text.Trim();
            str4 = textBox4.Text.Trim();


            if (db.gys.Any(m => m.gname == str1) == true)
            {
                MessageBox.Show("供应商名重复!");
                textBox1.Focus();
                return;
            }
            DBCL2.gy model = new DBCL2.gy();
            model.gname = str1;
            model.glxr = str2;
            model.glxfs = str3;
            model.bz = str4;
            try
            {
                db.gys.Add(model);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("添加失败!");
                return;
            }

            MessageBox.Show("添加成功!");
        }

        private void tjgys_Load(object sender, EventArgs e)
        {

        }
    }
}
