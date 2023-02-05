using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilder
    {
        string companyName;
        int working_Hour;
        int working_Day;
        int rate_Per_Daily_Wage;
        public EmpWageBuilder(string companyName, int working_Hour, int working_Day, int rate_Per_Daily_Wage)
        {
            this.companyName = companyName;
            this.working_Hour = working_Hour;
            this.working_Day = working_Day;
            this.rate_Per_Daily_Wage = rate_Per_Daily_Wage;
        }
    }
}
