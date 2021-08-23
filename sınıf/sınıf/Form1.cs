using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee personelDetaail = new Employee();
            personelDetaail.employeeID = Convert.ToInt32( textBox1.Text);
            personelDetaail.employeName = textBox2.Text;
            personelDetaail.employeeAge = Convert.ToInt32(textBox3.Text);
            MessageBox.Show(personelDetaail.employeeID + " " + personelDetaail.employeName+" "+ personelDetaail.employeeAge+" ");
        }
    }
}
