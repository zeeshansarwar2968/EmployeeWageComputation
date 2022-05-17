using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        public string companyName;
        public int emplHourlyRate;
        public int totalWorkingDays;
        public int totalWorkingHours;
        public int totalEmpWage;

        //Parameterised constructor
        public CompanyEmpWage(string companyName, int emplHourlyRate, int totalWorkingDays, int totalWorkingHours)
        {
            this.companyName = companyName;
            this.emplHourlyRate = emplHourlyRate;
            this.totalWorkingDays = totalWorkingDays;
            this.totalWorkingHours = totalWorkingHours;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toPrint()
        {
            return "The Total Wage of the Employee of Firm "+ this.companyName + " is : " + this.totalEmpWage;
        }
    }
    public class EmpWageBuilderArray
    {
        //Initialising constant variables to store values for use in logic design
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int companyCount = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        //Default constructor
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[10];
        }


        public void addCompanyEmpWage(string companyName, int emplHourlyRate, int totalWorkingDays, int totalWorkingHours)
        {
            companyEmpWageArray[this.companyCount] = new CompanyEmpWage(companyName, emplHourlyRate, totalWorkingDays, totalWorkingHours);
            companyCount++;
        }

        public void CalculateEmployeeWage()
        {
            for (int i = 0; i < companyCount; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.CalculateEmployeeWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toPrint());
            }
        }
        //Instance Method containing logic to find the total wage of an employee for the duration of a month or hours whose values are provided by the user
        public int CalculateEmployeeWage(CompanyEmpWage companyEmpWage)
        {
            //Initialising variables to store initial values for use in logic calculation
            int emplHours = 0, totalEmplWage = 0, totalDaysCount = 0, totalEmplHours = 0;
            //Initialising Random class instance
            Random NumRandom = new Random();

            while (totalEmplHours < companyEmpWage.totalWorkingHours && totalDaysCount < companyEmpWage.totalWorkingDays)
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
                //Console.Write("Day Count: {0}", totalDaysCount);
                //Console.WriteLine(" ||| Daily Employee Hours : " + emplHours);
                //Console.WriteLine("");
            }
            return totalEmplHours * companyEmpWage.emplHourlyRate;

            //Displaying total employee hours and wage
            //Console.WriteLine("total count of hours worked by Employee : {0}", totalEmplHours);
            //Console.WriteLine("The Total Wage of the Employee of Firm {1}  is : {0}", totalEmplWage, companyName);
        }
    }
}
