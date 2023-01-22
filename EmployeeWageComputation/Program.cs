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

            //Uc2 Calculate Daily Wage
            //Uc3 Calculate Daily Wage for Part time
            //Uc4 Using Switch case
            int empAttaindance = random.Next(3);//0 or 1 or 2 print
            //variable
            string type = "";
            int Per_Daily_Wage = 20;
            int Daily_Hour = 0;
            switch(empAttaindance)
            {
                case 0:
                type ="Absent";
                Daily_Hour = 0;
                    break;
                case 1:
                    type ="PartTimeJob";
                    Daily_Hour = 4;
                    break;
                default :
                    type ="FullTimeJob";
                    Daily_Hour = 8;
                    break;
            }  
            int dailyWage = Daily_Hour * Per_Daily_Wage;
            Console.WriteLine("Employee is {0}  and Daily Wage of emp is {1}", type, dailyWage);
            Console.ReadLine();
        }


    }
}