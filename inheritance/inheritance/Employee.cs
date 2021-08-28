using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Employee : Human
    {
        public int position { get; set; }
        public int salary { get; set; }

        public void setValues()
        {
            ID = 1;
            name = "İhsan";
            surname = "Dedeç";

        }
    }
}
