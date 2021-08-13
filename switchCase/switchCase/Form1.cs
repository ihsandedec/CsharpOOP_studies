using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string messageTex = "";

            switch (Convert.ToInt32(textBox1.Text))
            {
                case 2:
                    messageTex = "2 sayisini tuşladınız ";
                    break;
                case 4:
                    messageTex = "4 sayisini tuşladınız ";
                    break;
                case 6:
                    messageTex = "6 sayisini tuşladınız ";
                    switch (Convert.ToInt32(textBox2.Text))
                    {
                        case 1:
                            messageTex += "y=1";
                            break;
                        case 3:
                            messageTex += "y=3";
                            break;
                        default:
                             messageTex= "İstenilen sayilar dışında tuşlama yaptınız";
                            break;
                    }
                    break;
                default:
                    messageTex= "İstenilen sayilar dışında tuşlama yaptınız";
                    break;
            }
            MessageBox.Show(messageTex);
        }
    }
}
