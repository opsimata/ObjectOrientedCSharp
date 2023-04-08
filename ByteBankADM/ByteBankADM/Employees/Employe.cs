using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Employees
{
    public class Employe
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public double Salary { get; set; }

        public double GetBonus()
        {
            return this.Salary * 0.1;
        }
    }
}
