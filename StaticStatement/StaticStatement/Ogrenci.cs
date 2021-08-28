using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticStatement
{
    class Ogrenci
    {
        public static int ogrnNumara { get; set; }

        public static void ogrnNot()
        {
            MessageBox.Show("Static çalıştı");
        }
    }
}
