using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_dowhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0, y = 10;
            while (y<20)
            {
                textBox1.Text += y.ToString()+Environment.NewLine;
                x++;
                y++;
            }
            MessageBox.Show("Döngü "+x.ToString()+" kez çalışmıştır");
        }
    }
}
