using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClsKue
    {
        private string idkue, namakue, idjenis, gambarkue, ukurankue, bentukue, hargakue;

        public string IdKue
        {
            get { return idkue; }
            set { idkue = value; }
        }
        public string NamaKue
        {
            get { return namakue; }
            set { namakue = value; }
        }

        public string Idjenis
        {
            get { return idjenis; }
            set { idjenis = value; }
        }

        public string GambarKue
        {
            get { return gambarkue; }
            set { gambarkue = value; }
        }
        public string UkuranKue
        {
            get { return ukurankue; }
            set { ukurankue = value; }
        }

        public string BentukKue
        {
            get { return bentukue; }
            set { bentukue = value; }
        }

        public string HargaKue
        {
            get { return hargakue; }
            set { hargakue = value; }
        }
    }
}
