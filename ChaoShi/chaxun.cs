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
    public partial class chaxun : Form
    {
        DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public chaxun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";
            string str2 = "";
            string str3 = "";
            str1 = textBox1.Text.Trim();
            str2 = comboBox1.Text.Trim();
            str3 = textBox2.Text.Trim();

            var model = db.users.Select(m => new { m.uname, m.usex, m.uage, m.uphone, m.uadress, m.ubeizhu });
            //姓名
            if (str1 != "")
            {
                model = model.Where(m => m.uname.IndexOf(str1) >= 0);
            }
            //性别
            if (str2 != "")
            {
                model = model.Where(m => m.usex.IndexOf(str2) >= 0);
            }
            //所属部门
            if (str3 != "")
            {
                model = model.Where(m => m.uadress.IndexOf(str3) >= 0);
            }
            this.dataGridView1.DataSource = model.ToList();
        }

        private void chaxun_Load(object sender, EventArgs e)
        {

        }
    }
}
