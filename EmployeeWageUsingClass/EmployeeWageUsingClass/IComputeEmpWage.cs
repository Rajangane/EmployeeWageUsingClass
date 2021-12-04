using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ability to get the total wage when queried by company

namespace EmployeeWageUsingClass
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(String Company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void ComputeEmpWage();
        public int getTotalWage(String Company);

    }
}
