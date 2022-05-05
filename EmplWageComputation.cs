using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmplWageComputation
    {
        //Initialising variables to store the boolean value of an employees presence
        bool IsPresent;

        int isFullTime = 1;

        Random NumRandom = new Random();

        //Method containing logic to find the presence of employee
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
    }
}
