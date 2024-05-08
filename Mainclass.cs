using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace fast_food
{
    class Mainclass
    {


        public static readonly string con_string = "Data Source=.;Initial Catalog=fast food;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        //متد چک کردن درستی کاربر
        public static bool IsValidUser(string user, string pass)
        {
            bool isvalid = false;

            string qyr = @"select * from users where username ='" + user + "' and pass = '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qyr, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isvalid = true;
                USER = dt.Rows[0]["uname"].ToString();
            }

            return isvalid;

        }
        //متد نشون دادن نام کاربر وارد شده
        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }

        //برای بارگذاری داده ها از دیتا بیس
        public static void LoadeData(string qry, DataGridView gv, ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string ColName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[ColName1].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        public static void BlurBackground(Form Modele)
        {
            Form Background = new Form();
            using (Modele)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = mainform.Instans.Size;
                Background.Location = mainform.Instans.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Modele.Owner = Background;
                Modele.ShowDialog(Background);
                Background.Dispose();
            }
        }

        public static void cbFill(string qry, ComboBox cb)
        {
            using (SqlCommand cmd = new SqlCommand(qry, con))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb.DisplayMember = "name";
                cb.ValueMember = "id";
                cb.DataSource = dt;
                cb.SelectedIndex = -1;
            }
        }
    }
    }