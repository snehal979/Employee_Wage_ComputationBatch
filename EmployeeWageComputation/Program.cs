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
            obj.addComputerWage("DMart", 100, 20, 18);
            obj.computerWageEmployee();
            //Uc14
            Console.WriteLine("Total Wage Calculate For Company "+obj.ToGetEmpWage("DMart"));
            Console.ReadLine();
            
        }
    }
}