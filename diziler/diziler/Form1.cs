using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] days = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            for (int i = 0; i < days.Length; i++)
            {
                string rowtext = days[i];
                dataGridView1.Rows.Add(rowtext);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] rows = new string[,] {
                {"1" , "Pazartesi" },
                {"2", "Salı" },
                { "3","Çarşamba" },
                {"4", "Perşembe" },
                {"5", "Cuma" },
                {"6", "Cumartesi" },
                {"7" ,"Pazar" },
            };
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                string[] row = new string[rows.GetLength(0)];

                for (int k = 0; k < rows.GetLength(1); k++)
                {
                    row[k] = rows[i, k];
                }
                dataGridView2.Rows.Add(row);
            }

        }
    }
}

