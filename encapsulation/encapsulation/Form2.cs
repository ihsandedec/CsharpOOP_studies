using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encapsulation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Personel personelDetail02 = new Personel();
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = personelDetail02.personelID;
            label2.Text = personelDetail02.personeAd;
            label3.Text = personelDetail02.personelYas;
            label4.Text = personelDetail02.personelPozisyon;
        }
    }
}
