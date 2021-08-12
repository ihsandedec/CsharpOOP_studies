using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataTransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Surname = textBox2.Text;
            string NameSurname = Name + " " + Surname;
            frmShowDate frmShw = new frmShowDate();
            frmShw.label1.Text = NameSurname;
            frmShw.Show();
        }
    }
}
