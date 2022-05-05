using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmplWageCompSwitch
    {
        //Initialising constant and empty variables to store values
        const int isFullTime = 1;
        const int isPartTime = 2;
        const int emplHourlyRate = 20;

        int emplHours = 0;
        int emplWage = 0;

        Random NumRandom = new Random();

        //Method containing logic to find the wage of an employee if they are fulltime/parttime
        public void CalculateEmployeeWage()
        {
            int num = NumRandom.Next(0, 3);
            Console.WriteLine(num);

            switch (num)
            {
                case isFullTime:
                    emplHours = 8;
                    break;

                case isPartTime:
                    emplHours = 4;
                    break;

                default:
                    emplHours = 0;
                    break;
            }
            emplWage = emplHours * emplHourlyRate;
            Console.WriteLine("THe Wage of the Employee is : {0}", emplWage);
        }
    }
}