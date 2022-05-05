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
        const int totalWorkingDays = 20;

        int emplHours = 0;
        int emplWage = 0;
        int totalEmplWage = 0;

        Random NumRandom = new Random();

        //Method containing logic to find the wage of an employee for the duration of a month
        public void CalculateEmployeeWage()
        {
            for(int i = 0; i < totalWorkingDays; i++)
            {
                int num = NumRandom.Next(0, 3);
                //Console.WriteLine(num);

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
                totalEmplWage = totalEmplWage + emplWage;
                Console.WriteLine("Day: {0}",i+1);
                Console.WriteLine("Daily Employee Wage : "+emplWage);
                Console.WriteLine("");
            }
            Console.WriteLine("THe Total Monthly Wage of the Employee is : {0}", totalEmplWage);
        }
    }
}