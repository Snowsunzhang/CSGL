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
    public partial class Form2 : Form
    {
        private DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var model = db.users.Select(m =>new {m.uname,m.usex,m.uage,m.uphone,m.uadress,m.ubeizhu});
            this.dataGridView1.DataSource = model.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = this.dataGridView1.CurrentCell.RowIndex;
            string h = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            var model = db.users.FirstOrDefault(m => m.uname == h);
            try
            {
                db.users.Remove(model);
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
            xiugai xg = new xiugai();
            xg.name = h;
            xg.Show();
        }
    }
}
