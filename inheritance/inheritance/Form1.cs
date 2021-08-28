using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.setValues();
            teacher.setValues02();
            textBox1.Text += teacher.ID + Environment.NewLine;
            textBox1.Text += teacher.name + Environment.NewLine;
            textBox1.Text += teacher.surname + Environment.NewLine;
            textBox1.Text += teacher.position + Environment.NewLine;
            textBox1.Text += teacher.salary + Environment.NewLine;
            textBox1.Text += teacher.branch + Environment.NewLine;
        }
    }
}
