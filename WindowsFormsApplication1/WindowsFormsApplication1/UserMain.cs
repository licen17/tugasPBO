using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class UserMain
    {
        private MySqlCommand Conn = null;
        string konfigurasi = "Server=127.0.0.1;Port=3306;UID=root;Database=toko_kue";
        MySqlConnection koneksi = new MySqlConnection();

        public UserMain()
        {
            koneksi.ConnectionString = konfigurasi;
        }

        public DataSet getData()
        {
            DataSet ds = new DataSet();
            try
            {
                if (koneksi.State.Equals("Closed")) koneksi.Open();
                Conn = new MySqlCommand();
                Conn.Connection = koneksi;
                Conn.CommandType = CommandType.Text;
                Conn.CommandText = "SELECT id_user, username, level FROM tbl_user";
                MySqlDataAdapter mdap = new MySqlDataAdapter(Conn);
                mdap.Fill(ds, "tbl_user");
                koneksi.Close();
            }
            catch (MySqlException)
            {
            }
            return ds;
        }

        public bool insertData(ClsUser u)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                Conn = new MySqlCommand();
                Conn.Connection = koneksi;
                Conn.CommandType = CommandType.Text;
                Conn.CommandText = "INSERT INTO tbl_user VALUES ('" + u.IdUser + "','" + u.Username + "','" + u.Password + "','" + u.Level + "')";
                Conn.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }

            return stat;
        }

        public bool deleteData(string IdUser)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                Conn = new MySqlCommand();
                Conn.Connection = koneksi;
                Conn.CommandType = CommandType.Text;
                Conn.CommandText = "DELETE FROM tbl_user WHERE id_user='" + IdUser + "'";
                Conn.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }
            return stat;
        }

        public bool updateData(ClsUser u, string IdUser)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                Conn = new MySqlCommand();
                Conn.Connection = koneksi;
                Conn.CommandType = CommandType.Text;
                Conn.CommandText = "UPDATE tbl_user SET username='" + u.Username + "', password='" + u.Password + "', level='" + u.Level + "' WHERE id_user='" + u.IdUser + "'";
                Conn.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }
            return stat;
        }
    }
}
