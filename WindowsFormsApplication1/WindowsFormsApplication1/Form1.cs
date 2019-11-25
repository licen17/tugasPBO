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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.FromArgb(248, 169, 120);

            textBox2.ForeColor = Color.FromArgb(248, 169, 120);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            textBox2.ForeColor = Color.FromArgb(248, 169, 120);

            textBox1.ForeColor = Color.FromArgb(248, 169, 120);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 dsh = new Form2();
            dsh.Show();
        }
    }
}
