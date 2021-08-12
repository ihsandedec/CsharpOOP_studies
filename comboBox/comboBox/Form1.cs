using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pazartesi");
            comboBox1.Items.Add("Salı");
            comboBox1.Items.Add("Çarşamba");
            comboBox1.Items.Add("Perşembe");
            comboBox1.Items.Add("Cuma");

            comboBox2.Items.Add("Monday");
            comboBox2.Items.Add("Tuesday");
            comboBox2.Items.Add("Wednesday");
            comboBox2.Items.Add("Thursday");
            comboBox2.Items.Add("Friday");

            comboBox3.Items.Add("Mercedes");
            comboBox3.Items.Add("Opel");
            comboBox3.Items.Add("BMW");
            comboBox3.Items.Add("Scoda");
            comboBox3.Items.Add("Mazda");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //selectedındex çok tercih edilmez çünkü sıralama değiştiği zaman değerlerde değişir.
            //ındex numarası değişmeyecek şeyler için kullanılır.
            int slectedIndex = comboBox2.SelectedIndex;
            MessageBox.Show(slectedIndex.ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox3.SelectedItem.ToString();
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox3.SelectedItem.ToString();
        }
    }
}

