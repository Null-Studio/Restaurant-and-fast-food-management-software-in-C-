using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fast_food
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (Mainclass.IsValidUser(username.Text, password.Text) == false)
            {
                guna2MessageDialog1.Show("نام کاربری یا رمز عبور اشتباه است");
                return;
            }
            else
            {
                this.Hide();
                mainform mf = new mainform();
                mf.Show();
            }
        }
    }
}
