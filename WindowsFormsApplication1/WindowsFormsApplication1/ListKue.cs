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
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public partial class ListKue : Form
    {
        public ListKue()
        {
            InitializeComponent();
            lihatData();
        }

        //private string kode_kue;
        MySqlConnection koneksi = new MySqlConnection("server=localhost;database=toko_kue;uid=root;pwd=;");


        KueMain kue = new KueMain();
        string IdKue;

        void ViewData()
        {
            DataSet data = kue.getData();
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "tbl_kue";
        }
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray;


            ClsKue m = new ClsKue();
            m.IdKue = textIDKue.Text;
            m.NamaKue = textNamaKue.Text;
            m.Idjenis = textJenisKue.Text;
            m.GambarKue = pictureBox1.Image;
            m.UkuranKue = textUkuranKue.Text;
            m.BentukKue = textBentukKue.Text;
            m.HargaKue = textHargaKue.Text;
            kue.insertData(m);
            ViewData();
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
            ClsKue m = new ClsKue();
            m.IdKue = textIDKue.Text;
            m.NamaKue = textNamaKue.Text;
            m.Idjenis = textJenisKue.Text;
            //m.GambarKue = textGambarKue.Text;
            m.UkuranKue = textUkuranKue.Text;
            m.BentukKue = textBentukKue.Text;
            m.HargaKue = textHargaKue.Text;
            kue.updateData(m, IdKue);
            ViewData();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {

            ClsKue m = new ClsKue();
            m.IdKue = textIDKue.Text;
            m.NamaKue = textNamaKue.Text;
            m.Idjenis = textJenisKue.Text;
            //m.GambarKue = textGambarKue.Text;
            m.UkuranKue = textUkuranKue.Text;
            m.BentukKue = textBentukKue.Text;
            m.HargaKue = textHargaKue.Text;
            kue.deleteData(m.IdKue);
            ViewData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {

                Byte img = (Byte[])dataGridView1.CurrentRow.Cells[3].Value();
                MemoryStream ms = new MemoryStream(img);

                buttonSimpan.Enabled = false;

                textIDKue.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textNamaKue.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textJenisKue.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textUkuranKue.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBentukKue.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textHargaKue.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            buttonSimpan.Enabled = true;
            textIDKue.Text = "";
            textNamaKue.Text = "";
            textUkuranKue.Text = "";
            textJenisKue.Text = "";
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListUser listuser = new ListUser();
            listuser.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListKue listkue = new ListKue();
            listkue.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;)|*.JPG;*.PNG";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
