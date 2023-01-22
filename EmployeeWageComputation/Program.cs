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
            //Uc 5 Calculate Wage for month (for loop ) due to using final condition
            //variable
            string type = "";
            int Rate_Per_Daily_Wage = 20;
            int Daily_Hour = 0;
            int Working_Day = 20;
            int totaldailyWage = 0;
            for (int i = 1; i<=Working_Day; i++)
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
                totaldailyWage = totaldailyWage + Daily_Hour; //4=0+4
                Console.WriteLine("employee is {0}  and total hour working day is {1}", type, totaldailyWage);                                                  //12=4+8
            }
            int Total_Month_Wage = totaldailyWage * Rate_Per_Daily_Wage;
            Console.WriteLine("total month salary {0}", Total_Month_Wage);
            Console.ReadLine();   
        }
    }
}