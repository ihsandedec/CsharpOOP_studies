using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Teacher : Employee
    {
        public int branch { get; set; }
        public void setValues02()
        {
            position = 3;
            salary = 5500;
            branch = 12;

        }
    }
}
