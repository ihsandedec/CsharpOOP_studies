using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface Computer
        {
            void getDesktops();
            void getLaptops();

        }
        interface dellInterface
        {
            void dellLaptops();

        }
        class Dell : Computer,dellInterface
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public void dellLaptops()
            {
                Name = "dell laptops";
                Price = 7000;
            }

            public void getDesktops()
            {
                Name = "Desktop";
                Price = 10000;
            }

            public void getLaptops()
            {
                Name = "Laptops";
                Price = 12000;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Dell dell = new Dell();
            dell.getDesktops();
            textBox1.Text = dell.Name + " " + dell.Price + Environment.NewLine;
            dell.getLaptops();
            textBox1.Text += dell.Name + " " + dell.Price + Environment.NewLine;
            dell.dellLaptops();
            textBox1.Text += dell.Name + " " + dell.Price + Environment.NewLine;
        }
    }
}
