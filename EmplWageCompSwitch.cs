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
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMPL_HOURLY_RATE = 20;
        public const int TOTAL_WORKING_DAYS = 20;
        public const int TOTAL_WORKING_HOURS = 100;

        //Initialising Random class instance
        Random NumRandom = new Random();

        //Method containing logic to find the total wage of an employee for the duration of a month or hours amounting to 100
        public void CalculateEmployeeWage()
        {
            //Initialising variables to store initial values for use in logic calculation
            int emplHours = 0, totalEmplWage = 0, totalDaysCount = 0, totalEmplHours = 0;

            while(totalEmplHours <= TOTAL_WORKING_HOURS && totalDaysCount < TOTAL_WORKING_DAYS)
            {
                totalDaysCount++;
                int num = NumRandom.Next(0, 3);

                switch (num)
                {
                    case IS_FULL_TIME:
                        emplHours = 8;
                        break;

                    case IS_PART_TIME:
                        emplHours = 4;
                        break;

                    default:
                        emplHours = 0;
                        break;
                }
                totalEmplHours += emplHours;
                //Displaying daycount and employee hours for each iteration
                Console.WriteLine("Day Count: {0}", totalDaysCount);
                Console.WriteLine("Daily Employee Hours : "+emplHours);
                Console.WriteLine("");
            }
            totalEmplWage = totalEmplHours * EMPL_HOURLY_RATE;

            //Displaying total employee hours and wage
            Console.WriteLine("total count of hours worked by Employee : {0}", totalEmplHours);
            Console.WriteLine("The Total Wage of the Employee is : {0}", totalEmplWage);
        }
    }
}