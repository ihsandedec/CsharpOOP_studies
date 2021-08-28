using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double firstNumber = 0, secondNumber = 0;
        bool control = false;

        void Set1Parameter(string text)
        {
            if (text.Trim()!="")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
            }
            else
            {
                control = false;
            }

        }

        void Set2Parameter(string text, string text2)
        {
            if (text.Trim() != "" && text2.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
                secondNumber = Convert.ToDouble(text2);
            }
            else
            {
                control = false;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text boxlara sayıdan başka giriş olmaması için
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;
            if ((e.KeyChar == ',' && ((sender as TextBox).Text.IndexOf(',') > -1)))
                e.Handled = true;
        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text boxlara sayıdan başka giriş olmaması için
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;
            if ((e.KeyChar == ',' && ((sender as TextBox).Text.IndexOf(',') > -1)))
                e.Handled = true;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show("Lütfen bir değer giriniz");
            }
            else
            {
                txtResult.Text = Math.Max(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            Set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show("Lütfen bir değer giriniz");
            }
            else
            {
                txtResult.Text = Math.Abs(Convert.ToDecimal(firstNumber)).ToString();
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            Set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show("Lütfen bir değer giriniz");
            }
            else
            {
                txtResult.Text = Math.Sign(Convert.ToDecimal(firstNumber)).ToString();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show("Lütfen bir değer giriniz");
            }
            else
            {
                txtResult.Text = Math.Min(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }

        }

       
    }
}
