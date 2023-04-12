﻿using ByteBankADM.Utilitaries;

namespace ByteBankADM.Employees
{
    public class CEO : Employe
    {

        public CEO(string id) : base(id, 100000)
        {

        }

        public override void IncreaseWage()
        {
            this.Salary *= 1.01;
        }
        public override double GetBonus()
        {
            //return this.Salary + (base.GetBonus() * .35);
            return this.Salary * .35;
        }
    }
}