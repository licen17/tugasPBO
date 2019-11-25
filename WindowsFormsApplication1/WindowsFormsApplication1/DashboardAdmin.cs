using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListKue listkue = new ListKue();
            listkue.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListUser listuser = new ListUser();
            listuser.Show();
        }
    }
}
