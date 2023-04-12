using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Employees
{
    public class CEO : Employe
    {
        public double GetBonus()
        {
            return this.Salary;
        }
    }
}
