using System;

namespace EmployeeWageComputation
{
    class Program
    {
        //class variable
        public const int Working_Hour = 100;
        public const int Working_Day = 20;
        public const int Rate_Per_Daily_Wage = 20;
        /// <summary>
        /// Main Method (Entry Point)
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            
           CalcilatedTotalWage(); 
        }
        /// <summary>
        /// Uc7 Method for the Employee Total Wage 
        /// </summary>
        public static void CalcilatedTotalWage()
        {
            Console.WriteLine("WELCOME THE EMPLOYEE WAGE PROGRAM");
            //Uc1 
            Random random = new Random(); //Random method

            //Uc2 Calculate Daily Wage
            //Uc3 Calculate Daily Wage for Part time
            //Uc4 Using Switch case
            //Uc 5 Calculate Wage for month (for loop ) due to using final condition
            //Uc6 calculated Wage for Condition (total hour < 100)
            //variable
            string type = ""; 
            int Daily_Hour = 0;
            int totaldailyWage = 0;

            for (int i = 0; totaldailyWage < Working_Hour && i <= Working_Day; i++)
            {
                int empAttaindance = random.Next(3);//0 or 1 or 2 print
                switch (empAttaindance)
                {
                    case 0:
                        type ="Absent";
                        Daily_Hour = 0;
                        break;
                    case 1:
                        type ="PartTimeJob";
                        Daily_Hour = 4;
                        break;
                    default:
                        type ="FullTimeJob";
                        Daily_Hour = 8;
                        break;
                }
                totaldailyWage = totaldailyWage + Daily_Hour; 
                Console.WriteLine("employee is {0}  and total hour working day is {1}", type, totaldailyWage);
               Console.WriteLine("Days "+i); ;                                                  
            }
            int Total_Month_Wage = totaldailyWage * Rate_Per_Daily_Wage;
            Console.WriteLine("total month salary {0}", Total_Month_Wage);
            Console.ReadLine();
        }
    }
}