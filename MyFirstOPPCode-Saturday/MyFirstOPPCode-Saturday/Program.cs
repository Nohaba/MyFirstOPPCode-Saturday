using System;

namespace MyFirstOPPCode_Saturday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dateObjectBirthDate = new Date(1920, 2, 8);
                var dateObjectHiringDate = new Date(2023, 1, 1);


                Console.WriteLine("");

                Employee salaryEmployeeObject = new SalaryEmployee()
                {
                    Id = 10441041,
                    FirstName = "Maria",
                    LastName = "Sandoval",
                    BirthDate = dateObjectBirthDate,
                    HiringDate = dateObjectHiringDate,
                    IsActive = true,
                    Salary = 1600000.56M
                };
                Console.WriteLine(salaryEmployeeObject.ToString());

                Console.WriteLine();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
