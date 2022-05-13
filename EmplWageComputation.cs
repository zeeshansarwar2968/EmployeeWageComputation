using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmplWageComputation
    {
        //Initialising constant variables to store values for use in logic design
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
     

        //Static Method containing logic to find the total wage of an employee for the duration of a month or hours whose values are provided by the user
        public static void CalculateEmployeeWage(string companyName , int emplHourlyRate , int totalWorkingDays , int totalWorkingHours)
        {
            //Initialising variables to store initial values for use in logic calculation
            int emplHours = 0, totalEmplWage = 0, totalDaysCount = 0, totalEmplHours = 0;
            //Initialising Random class instance
            Random NumRandom = new Random();

            while (totalEmplHours <= totalWorkingHours && totalDaysCount < totalWorkingDays)
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
                Console.Write("Day Count: {0}", totalDaysCount);
                Console.WriteLine(" ||| Daily Employee Hours : " + emplHours);
                Console.WriteLine("");
            }
            totalEmplWage = totalEmplHours * emplHourlyRate;

            //Displaying total employee hours and wage
            Console.WriteLine("total count of hours worked by Employee : {0}", totalEmplHours);
            Console.WriteLine("The Total Wage of the Employee is : {0}", totalEmplWage);
        }
    }
}