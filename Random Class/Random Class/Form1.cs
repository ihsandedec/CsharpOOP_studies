using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label1.Text = rnd.Next().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label2.Text = rnd.Next(100).ToString();

        }

        private void btnRandom03_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label3.Text = rnd.Next(90,100).ToString();
        }

        private void btnRandom04_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label4.Text = rnd.Next(70, 100).ToString();
            label5.Text = rnd.Next(70, 100).ToString();
            label6.Text = rnd.Next(70, 100).ToString();
            label7.Text = rnd.Next(70, 100).ToString();
        }

        private void btnRandom05_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            byte[] Arrys = new byte[5];
            rnd.NextBytes(Arrys);
            label8.Text = Arrys[0].ToString();
            label9.Text = Arrys[1].ToString();
            label10.Text = Arrys[2].ToString();
            label11.Text = Arrys[3].ToString();
        }

        private void btnRandom06_Click(object sender, EventArgs e)
        {
            const string chars = "abcdefghıijklmnoöprsştuüvyzwqxABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string result = "";
            Random rndm02 = new Random();
            for (int i = 0; i < 6; i++)
            {
                result += chars[rndm02.Next(0, Convert.ToInt32(chars.Length))];
            }
            label12.Text = result;
        }
    }
}
