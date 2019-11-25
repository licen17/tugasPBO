using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClsUser
    {
        private string iduser, username, password, level;

        public string IdUser
        {
            get { return iduser; }
            set { iduser = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Level
        {
            get { return level; }
            set { level = value; }
        }
    }
}
