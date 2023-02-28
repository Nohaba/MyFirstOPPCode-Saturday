using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOPPCode_Saturday
{
    public abstract class Employee
    {
        #region properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        #endregion

        #region Methods

        public abstract int GetValueToPay();

        public override string ToString()
        {
            return $"-----EMPLOYEE----\n\t" +
                $"{Id} \n\t " +
                $"First Name:..........{FirstName} \n\t " +
                $"LastName:............{LastName} \n\t " +
                $"Birh Day:............{BirthDate} \n\t " +
                $"Hiring Date:.........{HiringDate} \n\t" +
                $" Is active?:.........{IsActive}";
        }

        #endregion
    }
}
