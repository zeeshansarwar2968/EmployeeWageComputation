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

            //Using the CalculateEmployeeWage method of the EmpWageBuilder class to operate on the provided input and calulating the wage of an employee
            EmpWageBuilder company1 = new EmpWageBuilder("Capcom", 25, 20, 100);
            EmpWageBuilder company2 = new EmpWageBuilder("Tesla", 32, 19, 90);

            company1.CalculateEmployeeWage();
            Console.WriteLine("---------------------------------------------------------");
            company2.CalculateEmployeeWage();

            Console.ReadKey();
        }

        //static void displayWage()
        //{
        //    //Taking in user input to calculate the required wage of an employee
        //    Console.Write("Please enter the Company Name: ");
        //    string companyName = Console.ReadLine();
        //    Console.Write("Please enter the Employee Hourly Rate : ");
        //    int hourlyRate = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Please enter the total number of working days : ");
        //    int totalWorkingDays = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Please enter the total number of working hours : ");
        //    int totalWorkingHours = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("");
        //    Console.WriteLine("-------------------------------------------------");

        //    Console.WriteLine("The Employee wage for the company {0} is", companyName);
        //    Console.WriteLine("");  
        //}
    }
}
