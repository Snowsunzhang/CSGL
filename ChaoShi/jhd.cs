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
    public partial class jhd : Form
    {
        DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public string name;
        public jhd()
        {
            InitializeComponent();
        }

        private void jhd_Load(object sender, EventArgs e)
        {
            label4.Text = name;
            label2.Text = DateTime.Now.ToString("MMddHmmss");
            label6.Text = "0";
            label8.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text.Trim();
            string str2 = textBox2.Text.Trim();
            var model = db.shangpins.Select(m => m);
            if (str1 != "")
            {
                model = model.Where(m => m.sno.IndexOf(str1) >= 0);
            }
            if (str2 != "")
            {
                model = model.Where(m => m.sname.IndexOf(str2) >= 0);
            }
            this.dataGridView2.DataSource = model.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = this.dataGridView2.CurrentCell.RowIndex;
            string h = this.dataGridView2.Rows[i].Cells[0].Value.ToString();
            var model = db.shangpins.FirstOrDefault(m => m.sno == h);
            model.shave = model.shave + Convert.ToInt32(textBox3.Text.Trim());
            db.SaveChanges();

            DBCL2.jinhuo model2 = new DBCL2.jinhuo();
            model2.no = label2.Text;
            model2.sno = model.sno;
            model2.snum = Convert.ToInt32(textBox3.Text.Trim());
            model2.price = decimal.Parse(model.sjinjia);
            model2.date1 = model.sdate;
            model2.date2 = model.sbaozhiqi;
            model2.date3 = DateTime.Now.ToString("yyyyMMdd");
            model2.scome = model.sdanwei;
            model2.sperson = name;
            db.jinhuos.Add(model2);
            db.SaveChanges();

            var model5 = db.jinhuos.Select(m => new { m.no, m.sno, m.snum, m.price , m.date1, m.date2,m.date3,m.scome,m.sperson });
            model5 = model5.Where(m => m.no.IndexOf(label2.Text) >= 0);
            this.dataGridView1.DataSource = model5.ToList();
            int a = 0;
            decimal b = 0;
            foreach (var item in model5)
            {
                a = a + item.snum;
                b = b + item.snum * item.price;
            }
            label6.Text = a.ToString();
            label8.Text = b.ToString();
        }
    }

}
