using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = 0.ToString();
            label2.Text = 60.ToString();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        int counter01=0;
        int counter02=60;
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = counter01;
            counter01++;

            if (counter02==0)
            {
                timer1.Stop();
                MessageBox.Show("Timer Durduruldu");
            }
            progressBar2.Value = counter02;
            counter02--;

            label1.Text = counter01.ToString();
            label2.Text = counter02.ToString();

            if (counter02%2==0)
            {
                button3.BackColor = Color.Red;
            }
            else
                button3.BackColor = Color.White;


        }
    }
}
