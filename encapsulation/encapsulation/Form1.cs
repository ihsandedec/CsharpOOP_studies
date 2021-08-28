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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel personelDetails = new Personel();
            personelDetails.personelID = textBox1.Text;
            personelDetails.personeAd = textBox2.Text;
            personelDetails.personelYas = textBox3.Text;
            personelDetails.personelPozisyon = textBox4.Text;
            Form2 form2 = new Form2();
            form2.personelDetail02 = personelDetails;
            form2.Show();
        }
    }
}
