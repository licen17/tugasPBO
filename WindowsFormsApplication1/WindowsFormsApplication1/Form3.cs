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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            lihatData();
        }

        private string kode_kue;
        MySqlConnection koneksi = new MySqlConnection("server=localhost;database=kue;uid=root;pwd=;");

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNamaKue_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "insert into tbl_kue(kode_kue, nama_kue,ukuran_kue,ket_kue) values (@kode_kue, @nama_kue, @ukuran_kue, @ket_kue)";
            cmd.Parameters.AddWithValue("@kode_kue", textKodeKue.Text);
            cmd.Parameters.AddWithValue("@nama_kue", textNamaKue.Text);
            cmd.Parameters.AddWithValue("@ukuran_kue", textUkuranKue.Text);
            cmd.Parameters.AddWithValue("@ket_kue", textKetKue.Text);
            MessageBox.Show("Sukses");
            cmd.ExecuteNonQuery();
            textKodeKue.Text = "";
            textNamaKue.Text = "";
            textUkuranKue.Text = "";
            textKetKue.Text = "";
            lihatData();
            koneksi.Close();
        }

        public void lihatData()
        {
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "select * from tbl_kue";
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
            cmd.CommandText = "UPDATE tbl_kue SET kode_kue=@kode_kue, nama_kue=@nama_kue,ukuran_kue=@ukuran_kue,ket_kue=@ket_kue WHERE kode_kue=@kode_kue";
            cmd.Parameters.AddWithValue("@kode_kue", textKodeKue.Text);
            cmd.Parameters.AddWithValue("@nama_kue", textNamaKue.Text);
            cmd.Parameters.AddWithValue("@ukuran_kue", textUkuranKue.Text);
            cmd.Parameters.AddWithValue("@ket_kue", textKetKue.Text);
            MessageBox.Show("Sukses");
            cmd.ExecuteNonQuery();
            textKodeKue.Text = "";
            textNamaKue.Text = "";
            textUkuranKue.Text = "";
            textKetKue.Text = "";
            lihatData();
            koneksi.Close();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "DELETE FROM tbl_kue WHERE kode_kue=@kode_kue";
            cmd.Parameters.AddWithValue("@kode_kue", textKodeKue.Text);
            MessageBox.Show("Sukses");
            cmd.ExecuteNonQuery();
            textKodeKue.Text = "";
            textNamaKue.Text = "";
            textUkuranKue.Text = "";
            textKetKue.Text = "";
            lihatData();
            koneksi.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                textKodeKue.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textNamaKue.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textUkuranKue.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textKetKue.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            textKodeKue.Text = "";
            textNamaKue.Text = "";
            textUkuranKue.Text = "";
            textKetKue.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string my_Param = txtSearch.Text;
            /* Nothing is entered, clear the ListBox */
            MySql.Data.MySqlClient.MySqlParameter myParam = new MySql.Data.MySqlClient.MySqlParameter();
            myParam.ParameterName = "@my_Param";
            myParam.Value = my_Param;

            string myQuery = "SELECT * FROM tbl_kue WHERE kode_kue LIKE '%" + @my_Param + "%' or nama_kue like '%" + @my_Param + "%' or ukuran_kue LIKE '%" + @my_Param + "%' or ket_kue like '%" + @my_Param + "%' ";
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
    }
}
