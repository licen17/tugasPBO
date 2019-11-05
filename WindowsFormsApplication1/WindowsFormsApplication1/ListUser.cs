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
    public partial class ListUser : Form
    {
        public ListUser()
        {
            InitializeComponent();
            lihatData();
        }

        private string id_user;
        MySqlConnection koneksi = new MySqlConnection("server=localhost;database=kue;uid=root;pwd=;");

        private void ListUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "insert into tbl_user(id_user, nama_user,username,password,level) values (@id_user, @nama_user, @username, @password, @level)";
            cmd.Parameters.AddWithValue("@id_user", textIDUser.Text);
            cmd.Parameters.AddWithValue("@nama_user", textNamaUser.Text);
            cmd.Parameters.AddWithValue("@username", textUsername.Text);
            cmd.Parameters.AddWithValue("@password", textPassword.Text);
            cmd.Parameters.AddWithValue("@level", textLevel.Text);
            MessageBox.Show("Sukses");
            cmd.ExecuteNonQuery();
            textIDUser.Text = "";
            textNamaUser.Text = "";
            textUsername.Text = "";
            textLevel.Text = "";
            lihatData();
            koneksi.Close();
        }
        public void lihatData()
        {
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "select id_user,nama_user, username, level from tbl_user";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "UPDATE tbl_user SET nama_user=@nama_user,username=@username, level=@level WHERE id_user=@id_user";
            cmd.Parameters.AddWithValue("@id_user", textIDUser.Text);
            cmd.Parameters.AddWithValue("@nama_user", textNamaUser.Text);
            cmd.Parameters.AddWithValue("@username", textUsername.Text);
            cmd.Parameters.AddWithValue("@password", textPassword.Text);
            cmd.Parameters.AddWithValue("@level", textLevel.Text);
            MessageBox.Show("Sukses");
            cmd.ExecuteNonQuery();
            textIDUser.Text = "";
            textNamaUser.Text = "";
            textUsername.Text = "";
            textPassword.Text = "";
            textLevel.Text = "";
            lihatData();
            koneksi.Close();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "DELETE FROM tbl_user WHERE id_user=@id_user";
            cmd.Parameters.AddWithValue("@id_user", textIDUser.Text);
            MessageBox.Show("Sukses");
            cmd.ExecuteNonQuery();
            textIDUser.Text = "";
            textNamaUser.Text = "";
            textUsername.Text = "";
            textPassword.Text = "";
            textLevel.Text = "";
            lihatData();
            koneksi.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                buttonSimpan.Enabled = false;
                textIDUser.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textNamaUser.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textUsername.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textLevel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            buttonSimpan.Enabled = true;
            textIDUser.Text = "";
            textNamaUser.Text = "";
            textUsername.Text = "";
            textPassword.Text = "";
            textLevel.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string my_Param = txtSearch.Text;
            /* Nothing is entered, clear the ListBox */
            MySql.Data.MySqlClient.MySqlParameter myParam = new MySql.Data.MySqlClient.MySqlParameter();
            myParam.ParameterName = "@my_Param";
            myParam.Value = my_Param;

            string myQuery = "SELECT * FROM tbl_user WHERE id_user LIKE '%" + @my_Param + "%' or nama_user like '%" + @my_Param + "%' or username LIKE '%" + @my_Param + "%' or level like '%" + @my_Param + "%' ";
            //textBox1.Text = myQuery;
            MySql.Data.MySqlClient.MySqlConnection myConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=kue;uid=root;pwd=;");
            MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myQuery, myConnection);
            myCommand.Parameters.Add(myParam);
            MySql.Data.MySqlClient.MySqlDataReader myDataReader;
            myConnection.Open();

            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(myQuery, myConnection);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            myDataReader = myCommand.ExecuteReader();
            myDataReader.Read();
            myDataReader.Close();
            myConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListUser listuser = new ListUser();
            listuser.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListKue listkue = new ListKue();
            listkue.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardAdmin dsh = new DashboardAdmin();
            dsh.Show();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
