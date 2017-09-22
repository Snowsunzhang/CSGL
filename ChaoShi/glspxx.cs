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
    public partial class glspxx : Form
    {
        private DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public glspxx()
        {
            InitializeComponent();
        }

        private void glspxx_Load(object sender, EventArgs e)
        {
            var model = db.shangpins.Select(m => m);
            this.dataGridView1.DataSource = model.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = this.dataGridView1.CurrentCell.RowIndex;
            string h = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            var model = db.shangpins.FirstOrDefault(m => m.sno == h);
            try
            {
                db.shangpins.Remove(model);
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
            xgspxx xg = new xgspxx();
            xg.sno = h;
            xg.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
