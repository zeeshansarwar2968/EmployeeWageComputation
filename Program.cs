using System;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
        
            EmplWageCompSwitch emplWageCompSwitch = new EmplWageCompSwitch();
            emplWageCompSwitch.CalculateEmployeeWage();
            
            Console.ReadKey();
        }
    }
}
