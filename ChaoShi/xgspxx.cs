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
    public partial class xgspxx : Form
    {
        private DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public string sno;
        public xgspxx()
        {
            InitializeComponent();
        }

        private void xgspxx_Load(object sender, EventArgs e)
        {
            var model = db.shangpins.FirstOrDefault(m => m.sno == sno);

            if (model == null)
            {
                return;
            }
            textBox1.Text = model.sno;
            textBox2.Text = model.sname;
            textBox3.Text = model.sdate;
            textBox4.Text = model.sleibie;
            textBox5.Text = model.sjinjia;
            textBox6.Text = model.sshoujia;
            textBox7.Text = model.sdanwei;
            textBox8.Text = model.sbaozhiqi;
            textBox9.Text = model.shave.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            string str7 = "";
            string str8 = "";
            int int9=0;

            str1 = textBox1.Text.Trim();
            str2 = textBox2.Text.Trim();
            str3 = textBox3.Text.Trim();
            str4 = textBox4.Text.Trim();
            str5 = textBox5.Text.Trim();
            str6 = textBox6.Text.Trim();
            str7= textBox7.Text.Trim();
            str8 = textBox8.Text.Trim();
            int9=Convert.ToInt32(textBox9.Text.Trim());


            var model = db.shangpins.FirstOrDefault(m => m.sno == sno);
            if (model == null)
            {
                MessageBox.Show("该用户在数据库中不存在!");
                return;
            }

            model.sno = str1;
            model.sname = str2;
            model.sdate = str3;
            model.sleibie = str4;
            model.sjinjia= str5;
            model.sshoujia= str6;
            model.sdanwei= str7;
            model.sbaozhiqi= str8;
            model.shave= int9;

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("编辑失败!");
                return;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

