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
    public partial class cxgys : Form
    {
        DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public cxgys()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";
            str1 = textBox1.Text.Trim();

            var model = db.gys.Select(m => m);
            //供应商名
            if (str1 != "")
            {
                model = model.Where(m => m.gname.IndexOf(str1) >= 0);
            }
            
            this.dataGridView1.DataSource = model.ToList();
        }

        private void cxgys_Load(object sender, EventArgs e)
        {

        }
    }
}
