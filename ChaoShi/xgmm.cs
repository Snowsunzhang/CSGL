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
    public partial class xgmm : Form
    {
        public string name;
        private DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public xgmm()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";
            string str2 = "";
            string str3 = "";
            str1 = tb1.Text.Trim();
            str2 = tb2.Text.Trim();
            str3 = tb3.Text.Trim();
            if (str2.Equals(str3))
            {
                var model = db.users.FirstOrDefault(m => m.uname == name);
                if (model.upassword.Equals(str1))
                {
                    model.upassword = str3;
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("修改成功!");
                        this.Close();
                    }
                    catch
                    {
                        label4.Text = "修改失败!";
                        return;
                    }
                }
                else
                {
                    label4.Text = "原密码不正确!";
                }
            }
            else
            {
                label4.Text = "新密码与确认密码不相同";
                return;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xgmm_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}
