using System;

namespace EmployeeWageComputation
{
    class Program
    {
        /// <summary>
        /// Main Method (Entry Point)
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME THE EMPLOYEE WAGE PROGRAM");
            EmplyeeWageMain obj= new EmplyeeWageMain();
            obj.addComputerWage("JIO", 90, 20, 10);
            obj.addComputerWage("TATA",100, 22, 20);
            obj.computerWageEmployee();
            Console.ReadLine();

        }
    }
}