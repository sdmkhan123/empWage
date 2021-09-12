using System;

namespace empWage
{
    class Program
    {
        //declare cost
        public const int fullTimePresent = 1;
        public const int partTimePresent = 2;
        public const int empRatePerHr = 20;
        public const int maxWorkingDays = 20;
        public const int maxWorkingHrs = 100;
        //Refactor the Code to write a Class Method to Compute Employee Wage
        public static int classMethodToComputeEmpWage()
        {
            //declare variable
            int empHr;
            int day = 1;
            int totalWorkHr = 0;
            //compute emp wage
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
                //calculate daily wage
                int dailyWage = empRatePerHr * empHr;
                Console.WriteLine("Daily wage is " + dailyWage);
                //calculate total work hour
                totalWorkHr += empHr;
            }
            //retuen total work hour
            return totalWorkHr;
        }
        //compute Employee Wage for multiple companies using class method
        public static void classMethodToComputeCompanyEmpWage(string CompanyName, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            //declare variable
            int empHr;
            int day = 1;
            int totalWorkHr = 0;
            //compute emp wage
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
                //calculate total work hour
                totalWorkHr += empHr;
            }
            int totalWage = empRatePerHr * totalWorkHr;
            Console.WriteLine("Total emp wage of " + CompanyName + " company is " + totalWage + " using class method");
        }
        static void Main(string[] args)
        {
            //Refactor the Code to write a Class Method to Compute Employee Wage
            int totalWorkHr = classMethodToComputeEmpWage();
            int totalWage = empRatePerHr * totalWorkHr;
            Console.WriteLine("Computer Total emp wage using class method is " + totalWage);
            //compute Employee Wage for multiple companies using class method
            Console.WriteLine("Enter number of company is present");
            int NumOfCompany = Convert.ToInt32(Console.ReadLine());
            //enters the companies detail
            while (NumOfCompany > 0)
            {
                Console.WriteLine("Enter company Name");
                string CompanyName = Console.ReadLine();
                Console.WriteLine("Enter emp rate per hour of company");
                int empRatePerHr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter max working days of company");
                int maxWorkingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter max working hour of company");
                int maxWorkingHrs = Convert.ToInt32(Console.ReadLine());
                //calling each company to compute seperate total wage
                classMethodToComputeCompanyEmpWage(CompanyName, empRatePerHr, maxWorkingDays, maxWorkingHrs);
                NumOfCompany--;
            }
        }
    }
}