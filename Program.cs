﻿using System;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmplWageComputation emplWageComp = new EmplWageComputation();
            emplWageComp.CalculateEmployeeWage();
            Console.ReadKey();
        }
    }
}
