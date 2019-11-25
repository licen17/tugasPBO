using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public string leveluser;
        public Login()
        {
            InitializeComponent();
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textUsername.ForeColor = Color.FromArgb(248, 169, 120);

            textPassword.ForeColor = Color.FromArgb(248, 169, 120);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textPassword.Clear();
            textPassword.PasswordChar = '*';
            textPassword.ForeColor = Color.FromArgb(248, 169, 120);

            textUsername.ForeColor = Color.FromArgb(248, 169, 120);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;
            MySqlConnection koneksi = new MySqlConnection("server=localhost;database=toko_kue;uid=root;pwd=;");
            MySqlDataAdapter cmd = new MySqlDataAdapter("select * from tbl_user where username = '" + textUsername.Text + "'and Password = '" + textPassword.Text +"'", koneksi);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            if(dt.Rows.Count>0)
            {
                leveluser = dt.Rows[0][3].ToString().Trim();
                if(leveluser=="admin")
                {
                    MessageBox.Show("Usernama dan Password are success, You Login as Admin", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    var form = new ListUser();
                    form.Show();
                }
                else if (leveluser=="manager")
                {
                    MessageBox.Show("Usernama dan Password are success, You login as Manager", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    var forms = new DashboardManager();
                    forms.Show();
                }
                else
                {
                    MessageBox.Show("Usernama dan Password are success, You login as Cashier", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    var forms = new DashboardKasir();
                    forms.Show();
                }
            }
            else
            {
                MessageBox.Show("incorrect username and Password", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = textUsername.Text;
                string password = textPassword.Text;
                MySqlConnection koneksi = new MySqlConnection("server=localhost;database=toko_kue;uid=root;pwd=;");
                MySqlDataAdapter cmd = new MySqlDataAdapter("select * from tbl_user where username = '" + textUsername.Text + "'and Password = '" + textPassword.Text + "'", koneksi);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    leveluser = dt.Rows[0][3].ToString().Trim();
                    if (leveluser == "admin")
                    {
                        MessageBox.Show("Usernama dan Password are success, You Login as Admin", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        var form = new ListUser();
                        form.Show();
                    }
                    else if (leveluser == "manager")
                    {
                        MessageBox.Show("Usernama dan Password are success, You login as Manager", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        var forms = new DashboardManager();
                        forms.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usernama dan Password are success, You login as Cashier", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        var forms = new DashboardKasir();
                        forms.Show();
                    }
                }
                else
                {
                    MessageBox.Show("incorrect username and Password", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ecat = new Form5();
            ecat.Show();
        }
    }
}
