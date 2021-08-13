using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time = dateTimePicker1.Value;
            MessageBox.Show(time.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // yıla 2 yıl ekleyerek ekrana yazdırdım.
            DateTime birtday = dateTimePicker2.Value.AddYears(2);
            MessageBox.Show(birtday.ToShortDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime birtday = dateTimePicker2.Value;
            label1.Text = birtday.AddYears(3).ToShortDateString();
            label2.Text = birtday.AddYears(-3).ToShortDateString();

        }
    }
}
