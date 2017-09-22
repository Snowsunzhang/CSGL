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
    public partial class cxshd : Form
    {
        DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public cxshd()
        {
            InitializeComponent();
        }

        private void cxshd_Load(object sender, EventArgs e)
        {
            var model = db.shouhuos.Select(m => new { m.no, m.sno, m.snum, m.price, m.outdate, m.sperson, m.sum1 });
            this.dataGridView1.DataSource = model.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";

            str1 = textBox1.Text.Trim();

            var model = db.shouhuos.Select(m => new { m.no, m.sno, m.snum, m.price, m.outdate, m.sperson, m.sum1 });
            //姓名
            if (str1 != "")
            {
                model = model.Where(m => m.no.IndexOf(str1) >= 0);
            }

            this.dataGridView1.DataSource = model.ToList();
        }
    }
}
