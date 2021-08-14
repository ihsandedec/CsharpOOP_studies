using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int control = 0;
        int ilkdeger, sondeger, divisibleNumber;
        string sonuc;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleNumber = Convert.ToInt32(comboBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim()== "" && textBox2.Text.Trim()=="")
            {
                errorProvider1.SetError(textBox1, "boş");
                MessageBox.Show("Lütfen Değer Giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("İşlme Yapacağınız Sayıyı Seçiniz","HATA",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else
            {
            ilkdeger = Convert.ToInt32(textBox1.Text);
            sondeger = Convert.ToInt32(textBox2.Text);

            for (int i = ilkdeger; i < sondeger+1; i++)
            {
                
                if (i%divisibleNumber == 0)
                {
                    sonuc += " " + i.ToString() + " ";
                    control++;
                    if (control%10 == 0)
                    {
                        sonuc += Environment.NewLine;
                    }
                }
            }

            textBox3.Text = sonuc;
            }


        }
    }
}
