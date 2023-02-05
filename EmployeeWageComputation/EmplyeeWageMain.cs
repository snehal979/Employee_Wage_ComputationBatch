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
    public class EmplyeeWageMain : IComputerWage
    {
        int numOfCompany =0;
        LinkedList<EmpWageBuilder> employeesList;
        Random random = new Random(); //Random method
        public EmplyeeWageMain()
        {
            this.employeesList = new LinkedList<EmpWageBuilder>();
        }
        public void addComputerWage(string companyName, int working_Hour, int working_Day, int rate_Per_Daily_Wage)
        {
           EmpWageBuilder empWageBuilder  = new EmpWageBuilder(companyName, working_Hour, working_Day, rate_Per_Daily_Wage);
            this.employeesList.AddLast(empWageBuilder);
        }

        public void computerWageEmployee()
        {
            foreach(EmpWageBuilder data in this.employeesList)
            {
                data.ToSetEmpWage(this.computerWageEmployee(data));
                Console.WriteLine(data.toString());
            }
            
        }
        public int computerWageEmployee(EmpWageBuilder empWage)
        {
            //variable
            string type = "";
            int Daily_Hour = 0;
            int totaldailyWage = 0;
            for (int i = 0; totaldailyWage < empWage.working_Hour && i <= empWage.working_Day; i++)
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
            int Total_Month_Wage = totaldailyWage * empWage.rate_Per_Daily_Wage;
            //Console.WriteLine(" Total month salary :"+ Total_Month_Wage +" "+"Company name : "+empWage.companyName);
            return Total_Month_Wage;
        }
    }
}
