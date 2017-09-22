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
    public partial class kc : Form
    {
        DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public kc()
        {
            InitializeComponent();
        }

        private void kc_Load(object sender, EventArgs e)
        {
            var model = db.shangpins.Select(m => m);
            this.dataGridView1.DataSource = model.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";
            string str2 = "";
            string str3 = "";
            int int1 = 0;
            int int2 = 0;
            str1 = textBox1.Text.Trim();
            str2 = textBox2.Text.Trim();
            str3 = textBox3.Text.Trim();
            var model = db.shangpins.Select(m => m);

            if (str1 != "")
            {
                model = model.Where(m => m.sno.IndexOf(str1) >= 0);
            }
            if (str2 != "")
            {
                model = model.Where(m => m.sname.IndexOf(str2) >= 0);
            }
            if (str3 != "")
            {
                model = model.Where(m => m.sleibie.IndexOf(str3) >= 0);
            }
            if (textBox4.Text.Trim() != "")
            {
                int1 = Convert.ToInt32(textBox4.Text.Trim());
                model = model.Where(m => m.shave  >= int1);
            }
            if (textBox5.Text.Trim() != "")
            {
                int2 = Convert.ToInt32(textBox5.Text.Trim());
                model = model.Where(m => m.shave <= int2);
            }

            this.dataGridView1.DataSource = model.ToList();
        }
    }
}
