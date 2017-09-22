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
   
    public partial class Login : Form
    {
         //变量 ********************************************************************
        private DBCL2.SupermarketEntities db = new DBCL2.SupermarketEntities();
        public string username;
        private void InitControls()
        {
            lbMessage.Text = "";
        }
        
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strID = "";
            string strName = "";
            if (textBox1.Text.Trim() == "")
            {
                lbMessage.Text = "用户名不能为空!";
                //MessageBox.Show("学号不能为空!");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                lbMessage.Text = "密码不能为空!";
                textBox2.Focus();
                return;
            }
            strID = textBox1.Text.Trim();
            strName = textBox2.Text.Trim();
            if (db.users.Any(m => m.uname == strID) == true)
            {
                if (db.users.Any(m => m.upassword == strName) == true)
                {
                    index form = new index();
                    form.name = strID;
                    form.name = strID;
                    this.Hide();
                    form.Show();
                }
                else
                {
                    lbMessage.Text = "密码错误!";
                    textBox2.Focus();
                    return;
                }
            }



         
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
