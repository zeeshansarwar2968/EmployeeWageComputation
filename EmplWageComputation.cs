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
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int emplHourlyRate = 20;

        public int emplHours = 0;
        public int emplWage = 0;

        Random NumRandom = new Random();

        //Initialising global variables to store initial values for use in logic design
        public void CheckEmployeePresence()
        {
            int num = NumRandom.Next(0,2);
            Console.WriteLine(num);

            if(num == isFullTime)
            {
                Console.WriteLine("Employee is Present");
            }else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

        //Method containing logic to find the wage of an employee if they are fulltime/parttime
        public void CalculateEmployeeWage()
        {
            int num = NumRandom.Next(0, 3);
            Console.WriteLine(num);

            if (num == isFullTime)
            {
                emplHours = 8;
            }
            else if (num == isPartTime)
            {
                emplHours = 4;
            }
            else
            {
                emplHours = 0;
            }
            emplWage = emplHours * emplHourlyRate;
            Console.WriteLine("THe Wage of the Employee is : {0}",emplWage);
        }
    }
}
