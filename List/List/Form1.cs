using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        List<int> numberList = new List<int>();
        List<string> textList = new List<string>();
        List<Employee> list = new List<Employee>();
        List<Days> dayList = new List<Days>();
        void fillList()
        {
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Employee employee1 = new Employee();
            employee1.EmployeeId = 1;
            employee1.Name = "ihsan";
            employee1.Surname = "dedeç";
            Employee employee2 = new Employee();
            employee2.EmployeeId = 2;
            employee2.Name = "ismail";
            employee2.Surname = "dedeç";
            Employee employee3 = new Employee();
            employee3.EmployeeId = 3;
            employee3.Name = "asaf";
            employee3.Surname = "dedeç";
            list.Add(employee1);
            list.Add(employee2);
            list.Add(employee3);
            Days day1 = new Days();
            day1.ID = 1;
            day1.textValue = "Pazartesi";
            dayList.Add(day1);
            Days day2 = new Days();
            day2.ID = 2;
            day2.textValue = "Salı";
            dayList.Add(day2);
            Days day3 = new Days();
            day3.ID = 3;
            day3.textValue = "Çarşamba";
            dayList.Add(day3);
            Days day4 = new Days();
            day4.ID = 4;
            day4.textValue = "Perşembe";
            dayList.Add(day4);
            Days day5 = new Days();
            day5.ID = 5;
            day5.textValue = "Cuma";
            dayList.Add(day5);
            Days day6 = new Days();
            day6.ID = 6;
            day6.textValue = "Cumartesi";
            dayList.Add(day6);
            Days day7 = new Days();
            day7.ID = 7;
            day7.textValue = "Pazar";
            dayList.Add(day7);

            cmbDays.DataSource = dayList;
            cmbDays.DisplayMember = "textValue";
            cmbDays.ValueMember = "ID";
            dataGridView1.DataSource = dayList;
        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                textBox1.Text += item.EmployeeId.ToString() + "-> " + item.Name + " " + item.Surname + " " + Environment.NewLine;
            }
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
