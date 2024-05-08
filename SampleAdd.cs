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
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        public virtual void btncloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void btnsave_Click(object sender, EventArgs e)
        {

        }
    }
}
