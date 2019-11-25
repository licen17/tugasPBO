using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class KueMain
    {

        private MySqlCommand Conn = null;
        string konfigurasi = "Server=127.0.0.1;Port=3306;UID=root;Database=toko_kue";
        MySqlConnection koneksi = new MySqlConnection();

        public KueMain()
        {
            koneksi.ConnectionString = konfigurasi;
        }

        public DataSet getData()
        {
            DataSet ds = new DataSet();
            try
            {
                if(koneksi.State.Equals("Closed")) koneksi.Open();
                Conn = new MySqlCommand();
                Conn.Connection = koneksi;
                Conn.CommandType = CommandType.Text;
                Conn.CommandText = "SELECT id_kue, nama_kue, id_jenis, gambar_kue, ukuran_kue, bentuk_kue, harga_kue FROM tbl_kue";
                MySqlDataAdapter mdap = new MySqlDataAdapter(Conn);
                mdap.Fill(ds, "tbl_kue");
                koneksi.Close();
            }
            catch (MySqlException)
            {
            }
            return ds;
        }

        public bool insertData(ClsKue k)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                Conn = new MySqlCommand();
                Conn.Connection = koneksi;
                Conn.CommandType = CommandType.Text;
                Conn.CommandText = "INSERT INTO tbl_kue VALUES ('" + k.IdKue + "','" + k.NamaKue + "','" + k.Idjenis + "','" + k.GambarKue + "','" + k.UkuranKue + "','" + k.BentukKue + "','" + k.HargaKue + "')";
                Conn.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }

            return stat;
        }

        public bool deleteData(string IdKue)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                Conn = new MySqlCommand();
                Conn.Connection = koneksi;
                Conn.CommandType = CommandType.Text;
                Conn.CommandText = "DELETE FROM tbl_kue WHERE id_kue='" + IdKue + "'";
                Conn.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }
            return stat;
        }

        public bool updateData(ClsKue k, string IdKue)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                Conn = new MySqlCommand();
                Conn.Connection = koneksi;
                Conn.CommandType = CommandType.Text;
                Conn.CommandText = "UPDATE tbl_kue SET nama_kue='" + k.NamaKue + "', id_jenis='" + k.Idjenis + "', ukuran_kue='"  + k.UkuranKue + "', bentuk_kue='" + k.BentukKue + "', harga_kue='" + k.HargaKue + "' WHERE id_kue='" + k.IdKue + "'";
                Conn.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }
            return stat;
        }
    }
}
