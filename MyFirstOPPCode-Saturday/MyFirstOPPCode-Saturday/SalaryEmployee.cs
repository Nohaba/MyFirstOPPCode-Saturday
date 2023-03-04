using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyFirstOPPCode_Saturday
{
    public class SalaryEmployee : Employee
    {
        #region properties
        public decimal Salary { get; set; }
        #endregion

        #region Methods 
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n\t "+
                $"Value to pay:........{GetValueToPay():C2}";
            #endregion
        }
    }
}
