using fast_food.Modele;
using fast_food.View;
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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        //برای دسترسی به فرم اصلی
        static mainform _obj;

        public static mainform Instans
        {
            get { if (_obj == null) { _obj = new mainform(); } return _obj; }
        }
        //متد اضافه کردن کنترل ها به فرم اصلی
        public void AddControlers(Form f)
        {
            guna2Panel1.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            guna2Panel1.Controls.Add(f);
            f.Show();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            labeluser.Text = Mainclass.USER;
            _obj = this;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            AddControlers(new Homeform());
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            AddControlers(new frmCategoryView());
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            AddControlers(new frmStaffView());
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            AddControlers(new frmProductView());
        }

        private void btnpos_Click(object sender, EventArgs e)
        {
            frmPos frm = new frmPos();
            frm.Show();
        }

        private void btnkitchen_Click(object sender, EventArgs e)
        {
            AddControlers(new frmkitchenView());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControlers(new frmTableView());
        }
    }
}
