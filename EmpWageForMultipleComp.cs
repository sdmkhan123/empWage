using System;
using System.Collections.Generic;
using System.Text;

namespace empWage
{
    class EmpWageForMultipleComp
    {
        public const int fullTimePresent = 1;
        public const int partTimePresent = 2;

        public void classMethodToComputeEmpWage(string CompanyName, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            int empHr;
            int day = 1;
            int totalWorkHr = 0;
            while (day <= maxWorkingDays && totalWorkHr <= maxWorkingHrs)
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
                totalWorkHr += empHr;
            }
            int totalWage = empRatePerHr * totalWorkHr;
            Console.WriteLine("Total emp wage of " + CompanyName + " company is " + totalWage);

        }
    }
}