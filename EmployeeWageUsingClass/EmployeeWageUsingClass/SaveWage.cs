using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//compute employee wage and save total wage by company 

namespace EmployeeWageUsingClass
{
    public class SaveWage 
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FUL_TIME = 2;

        private String company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public SaveWage(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void ComputeWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //computation
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays <= this.numOfWorkingDays)
            {
                
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FUL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days :" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
             totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("total emp wage for company : " + company + "is: " + totalEmpWage);
          
        }

    }
}
