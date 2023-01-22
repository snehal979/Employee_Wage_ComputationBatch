using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME THE EMPLOYEE WAGE PROGRAM");
            //Uc1 
            Random random = new Random(); //Random method
            int empAttaindance = random.Next(2);//0 or 1 print
            //Uc2 Calculate Daily Wage
            //variable
            string type = "";
            int Per_Daily_Wage = 20;
            int Daily_Hour = 0;
            if (empAttaindance == 0)
            {
                type ="Absent";
                Daily_Hour = 0;
            }
            else
            {
                type ="Present";
                Daily_Hour = 8;
            }
            int dailyWage = Daily_Hour * Per_Daily_Wage;
            Console.WriteLine("Employee is {0}  and Daily Wage of emp is {1}", type, dailyWage);
            Console.ReadLine();
        }


    }
}