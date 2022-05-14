using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string password = txt_Password.Text;

            if(username == "Bie" && password =="123")
            {
                frm_Home fh = new frm_Home();
                fh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your Username or Password");
            }
        }

        private void CB_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_ShowPassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }
    }
}
