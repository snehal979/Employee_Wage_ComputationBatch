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
            EmplyeeWageMain Tata= new EmplyeeWageMain();
            Tata.CalcilatedTotalWage( 90, 20, 10);

            EmplyeeWageMain JIO = new EmplyeeWageMain();
            JIO.CalcilatedTotalWage(100, 22, 20);
          
        }
    }
}