using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageUsingClass
{
    public class CompanyEmpWage
    {
        public String Company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(String Company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.Company = Company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = 0;

        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage=totalEmpWage;

        }
        public String toString()
        {
            return "total emp wage for company : " + this.Company + " is : " + this.totalEmpWage;

        }
    }
}