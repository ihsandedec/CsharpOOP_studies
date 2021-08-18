using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void hideRadioButtons()
        {
            groupBox1.Visible = false;
        }

        public void clearText()
        {
            textBox1.Clear();
        }

        public string fillTextBox()
        {
            string text = textBox1.Text;
            return text;
        }
        public void setNumber(string text)
        {
            label1.Text = text;
        }

         int sum(int x, int y)
        {
            int sumResult;
            sumResult = x + y;
            return sumResult;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hideRadioButtons();
            clearText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = fillTextBox();
            clearText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setNumber(textBox1.Text);
            clearText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = sum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            MessageBox.Show(toplam.ToString());
        }
    }
}
