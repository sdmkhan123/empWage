using System;

namespace empWage
{
    class Program
    {
        public const int fullTimePresent = 1;
        public const int partTimePresent = 2;
        public const int empRatePerHr = 20;
        public const int maxWorkingDays = 20;
        public const int maxWorkingHrs = 100;

        public static int classMethodToComputeEmpWage()
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
                int dailyWage = empRatePerHr * empHr;
                Console.WriteLine("Daily wage is " + dailyWage);
                totalWorkHr += empHr;
            }
            return totalWorkHr;
        }

        static void Main(string[] args)
        {
            int totalWorkHr = classMethodToComputeEmpWage();
            //Refactor the Code to write a Class Method to Compute Employee Wage
            int totalWage = empRatePerHr * totalWorkHr;
            Console.WriteLine("Total wage is " + totalWage);
            //compute Employee Wage for multiple companies
            EmpWageForMultipleComp totalWageOfEachComp = new EmpWageForMultipleComp();
            totalWageOfEachComp.classMethodToComputeEmpWage("CompanyOne", 20, 20, 100);
            totalWageOfEachComp.classMethodToComputeEmpWage("CompanyTwo", 3, 30, 80);
            totalWageOfEachComp.classMethodToComputeEmpWage("CompanyThree", 15, 10, 30);
        }
    }
}
