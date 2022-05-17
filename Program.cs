using System;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t Welcome to Employee Wage Computation Program");
            Console.WriteLine("");

            Console.WriteLine("The following is the calculated wage of two companies : ");
            Console.WriteLine("---------------------------------------------------------");

            //Using the addCompanyEmpWage method of the EmpWageBuilderArray class to operate on the provided inputs and calulating the wage of an employee
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Tesco",20,20,100);
            empWageBuilder.addCompanyEmpWage("Tesla",20,20,100);

            empWageBuilder.CalculateEmployeeWage();
            Console.WriteLine("---------------------------------------------------------");

            Console.ReadKey();
        }

        
    }
}
