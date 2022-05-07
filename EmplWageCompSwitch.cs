using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmplWageCompSwitch
    {
        //Initialising constant variables to store values for use in logic design
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int emplHourlyRate = 20;
        public const int totalWorkingDays = 20;
        public const int totalWorkingHours = 100;

        //Initialising global variables to store initial values for use in logic design
        public int emplHours = 0;
        public int totalEmplHours = 0;
        //int emplWage = 0;
        public int totalEmplWage = 0;
        public int totalDaysCount = 0;

        Random NumRandom = new Random();

        //Method containing logic to find the total wage of an employee for the duration of a month or hours amounting to 100
        public void CalculateEmployeeWage()
        {
            while(totalEmplHours <= totalWorkingHours && totalDaysCount < totalWorkingDays )
            {
                totalDaysCount++;
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
                totalEmplHours = totalEmplHours + emplHours;
                //emplWage = emplHours * emplHourlyRate;
                //totalEmplWage = totalEmplWage + emplWage;
                Console.WriteLine("Day Count: {0}", totalDaysCount);
                Console.WriteLine("Daily Employee Hours : "+emplHours);
                Console.WriteLine("");
            }
            totalEmplWage = totalEmplHours * emplHourlyRate;
            Console.WriteLine("total count of hours worked by Employee : {0}", totalEmplHours);
            Console.WriteLine("The Total Wage of the Employee is : {0}", totalEmplWage);
        }
    }
}