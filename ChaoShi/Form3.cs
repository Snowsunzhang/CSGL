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
    public partial class Form3 : Form
    {
        private DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var model = db.gys.Select(m => m);
            this.dataGridView1.DataSource = model.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = this.dataGridView1.CurrentCell.RowIndex;
            string h = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            var model = db.gys.FirstOrDefault(m => m.gname == h);
            try
            {
                db.gys.Remove(model);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("删除失败!");
                return;
            }

            MessageBox.Show("删除成功!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = this.dataGridView1.CurrentCell.RowIndex;
            string h = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            xiugai2 xg = new xiugai2();
            xg.name = h;
            xg.Show();
        }

    }
}
