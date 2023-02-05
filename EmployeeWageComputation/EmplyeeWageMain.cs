using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    /// <summary>
    /// Uc8 Class Method 
    /// </summary>
    public class EmplyeeWageMain 
    {
        EmpWageBuilder emp;
        Random random = new Random(); //Random method
        public void CalcilatedTotalWage(string companyName, int working_Hour, int working_Day, int rate_Per_Daily_Wage)
        {
            //variable
            string type = "";
            int Daily_Hour = 0;
            int totaldailyWage = 0;
            emp = new EmpWageBuilder(companyName, working_Hour, working_Day, rate_Per_Daily_Wage);
            for (int i = 0; totaldailyWage < working_Hour && i <= working_Day; i++)
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
            }
            int Total_Month_Wage = totaldailyWage * rate_Per_Daily_Wage;
            Console.WriteLine(" Total month salary :"+ Total_Month_Wage +" "+"Company name : "+companyName);
        }
    }
}
