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
    public partial class cxjhd : Form
    {
        DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public cxjhd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";
            
            str1 = textBox1.Text.Trim();

            var model = db.jinhuos.Select(m => new { m.no, m.sno, m.snum, m.price, m.date1, m.date2, m.date3, m.scome, m.sperson });
            //姓名
            if (str1 != "")
            {
                model = model.Where(m => m.no.IndexOf(str1) >= 0);
            }
           
            this.dataGridView1.DataSource = model.ToList();
        }

        private void cxjhd_Load(object sender, EventArgs e)
        {
            var model = db.jinhuos.Select(m => new { m.no, m.sno, m.snum, m.price, m.date1, m.date2, m.date3, m.scome, m.sperson });
            this.dataGridView1.DataSource = model.ToList();
        }
    }
}
