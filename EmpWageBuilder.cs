using System;
using System.Collections.Generic;
using System.Text;

namespace empWage
{
    public class EmpWageBuilder
    {
        public const int fullTimePresent = 1;
        public const int partTimePresent = 2;

        private string CompanyName;
        private int empRatePerHr;
        private int maxWorkingDays;
        private int maxWorkingHrs;
        private int totalWage;
        //Declare a constructor to create  object of that type
        public EmpWageBuilder(string CompanyName, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            this.CompanyName = CompanyName;
            this.empRatePerHr = empRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public void computeEmpWageofEachCompany()
        {
            //declare variable
            int empHr = 0;
            int day = 1;
            int totalWorkHr = 0;
            //compute emp wage
            while (day <= this.maxWorkingDays && totalWorkHr <= this.maxWorkingHrs)
            {
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {
                    case fullTimePresent:
                        empHr = 8;
                        break;
                    case partTimePresent:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                day++;
                //calculate total work hour
                totalWorkHr += empHr;
            }
            totalWage = this.empRatePerHr * totalWorkHr;
        }
        // to show total company wage of each emp
        public void toShowWage()
        {
            Console.WriteLine("Total emp wage of " + this.CompanyName + " company is " + this.totalWage);
        }
    }
}