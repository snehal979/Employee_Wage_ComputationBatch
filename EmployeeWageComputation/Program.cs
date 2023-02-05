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
            obj.CalcilatedTotalWage("JIO", 90, 20, 10);
            obj.CalcilatedTotalWage("TATA",100, 22, 20);
            Console.ReadLine();

        }
    }
}