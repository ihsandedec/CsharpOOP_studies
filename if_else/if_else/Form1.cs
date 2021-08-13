using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu Ürünü Almak İster Misiniz ?", "Control", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                textBox1.Text = "Bizi Tercih Ettiğiniz İçin Teşekkürler ";
            }
            else if (result == DialogResult.No)
            {
                textBox1.Text = "Yinede Teşekkür Ederiz";
            }
            else
            {
                textBox1.Text = "Çıkış Yapmadan Mutlaka Diğer Ürünlerimeze de Bakınız";
            }
        }

        private void btnternary_Click(object sender, EventArgs e)
        {
            //soru işaretinden önceki değer kontrol edilen değişken , doğru ise : solundaki değer çalışır (if) , yanlışsa sağındaki değer çalışır (else)
            int a = 5, b = 10;
            string ternaryresult;
            ternaryresult = a < b ? b.ToString() : a.ToString();
            textBox2.Text = ternaryresult;
        }
    }
}
