using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    //Interface
    public interface IComputerWage
    {
        public void addComputerWage(string companyName, int working_Hour, int working_Day, int rate_Per_Daily_Wage);
        public void computerWageEmployee();
    }
    public class EmpWageBuilder
    {
        public string companyName;
        public int working_Hour;
        public int working_Day;
        public int rate_Per_Daily_Wage;
        public int Total_Month_Wage;
        public EmpWageBuilder(string companyName, int working_Hour, int working_Day, int rate_Per_Daily_Wage)
        {
            this.companyName = companyName;
            this.working_Hour = working_Hour;
            this.working_Day = working_Day;
            this.rate_Per_Daily_Wage = rate_Per_Daily_Wage;
        }
        public int ToSetEmpWage(int Total_Month_Wage)
        {
            return this.Total_Month_Wage = Total_Month_Wage;
        }
        public override string ToString()
        {
            return " Total month salary :"+ this.Total_Month_Wage +" Company name : "+this.companyName;
        }
    }
}
