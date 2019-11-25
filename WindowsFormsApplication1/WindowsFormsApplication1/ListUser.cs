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

        //private string id_user;
        MySqlConnection koneksi = new MySqlConnection("server=localhost;database=toko_kue;uid=root;pwd=;");
        UserMain us = new UserMain();
        string IdUser;

        private void ListUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {

            ClsUser u = new ClsUser();
            u.IdUser = textIDUser.Text;
            u.Username = textUsername.Text;
            u.Password = textPassword.Text;
            u.Level = textLevel.Text;
            us.insertData(u);
            lihatData();
        }
        public void lihatData()
        {
            DataSet data = us.getData();
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "tbl_user";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ClsUser u = new ClsUser();
            u.IdUser = textIDUser.Text;
            u.Username = textUsername.Text;
            u.Password = textPassword.Text;
            u.Level = textLevel.Text;
            us.updateData(u, IdUser);
            lihatData();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            ClsUser u = new ClsUser();
            u.IdUser = textIDUser.Text;
            u.Username = textUsername.Text;
            u.Password = textPassword.Text;
            u.Level = textLevel.Text;
            us.deleteData(u.IdUser);
            lihatData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                buttonSimpan.Enabled = false;
                textIDUser.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //textPassword.Text = dataGridView1.CurrentRow.Cells[].Value.ToString();
                textLevel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            buttonSimpan.Enabled = true;
            textIDUser.Text = "";
            textUsername.Text = "";
            textPassword.Text = "";
            textLevel.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string my_Param = txtSearch.Text;
            /* Nothing is entered, clear the ListBox */
            MySql.Data.MySqlClient.MySqlParameter myParam = new MySqlParameter();
            myParam.ParameterName = "@my_Param";
            myParam.Value = my_Param;

            string myQuery = "SELECT * FROM tbl_user WHERE id_user LIKE '%" + @my_Param + "%' or username like '%" + "%' or level like '%" + @my_Param + "%' ";
            //textBox1.Text = myQuery;
            MySqlConnection myConnection = new MySqlConnection("server=localhost;database=toko_kue;uid=root;pwd=;");
            MySqlCommand myCommand = new MySqlCommand(myQuery, myConnection);
            myCommand.Parameters.Add(myParam);
            MySqlDataReader myDataReader;
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
