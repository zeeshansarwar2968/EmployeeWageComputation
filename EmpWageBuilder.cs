using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string companyName, int emplHourlyRate, int totalWorkingDays, int totalWorkingHours);

        public void CalculateEmployeeWage();

    }
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
            this.totalEmpWage = 0;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string printWage()
        {
            return "The Total Wage of the Employee of Firm "+ this.companyName + " is : " + this.totalEmpWage;
        }
    }
    public class EmpWageBuilder : IComputeEmpWage
    {
        //Initialising constant variables to store values for use in logic design
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        //private int companyCount = 0;
        private LinkedList<CompanyEmpWage> companyEmpWagesList;
        //private CompanyEmpWage[] companyEmpWageArray;

        //Default constructor
        public EmpWageBuilder()
        {
            this.companyEmpWagesList = new LinkedList<CompanyEmpWage>();
        }


        public void addCompanyEmpWage(string companyName, int emplHourlyRate, int totalWorkingDays, int totalWorkingHours)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, emplHourlyRate, totalWorkingDays, totalWorkingHours);
            this.companyEmpWagesList.AddLast(companyEmpWage);
        }

        public void CalculateEmployeeWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWagesList)
            {
                companyEmpWage.setTotalEmpWage(this.CalculateEmployeeWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.printWage());
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
