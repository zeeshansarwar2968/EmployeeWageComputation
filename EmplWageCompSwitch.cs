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
        const int totalWorkingHours = 100;

        int emplHours = 0;
        int totalEmplHours = 0;
        int emplWage = 0;
        int totalEmplWage = 0;
        int totatDaysCount = 0;

        Random NumRandom = new Random();

        //Method containing logic to find the total wage of an employee for the duration of a month or hours amounting to 100
        public void CalculateEmployeeWage()
        {
            while(totalEmplHours <= totalWorkingHours && totatDaysCount < totalWorkingDays )
            {
                totatDaysCount++;
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
                Console.WriteLine("Day Count: {0}", totatDaysCount);
                Console.WriteLine("Daily Employee Hours : "+emplHours);
                Console.WriteLine("");
            }
            totalEmplWage = totalEmplHours * emplHourlyRate;
            Console.WriteLine("totalEmplHours : {0}", totalEmplHours);
            Console.WriteLine("The Total Wage of the Employee is : {0}", totalEmplWage);
        }
    }
}