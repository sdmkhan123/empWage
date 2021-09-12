using System;

namespace empWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC-14 Manage Employee Wage of multiple companies using Array of Object
            Console.WriteLine("UC-14 code for Manage Employee Wage of multiple companies using Interface, Dictionary and ArrayList of Object");
            Console.WriteLine("Enter number of company is present");
            int NumOfCompany = Convert.ToInt32(Console.ReadLine());
            EmpWageBuilder empWageBuilderArray = new EmpWageBuilder();
            for(int i=0; i< NumOfCompany; i++)
            {
                Console.WriteLine("Enter company Name");
                string CompanyName = Console.ReadLine();
                Console.WriteLine("Enter emp rate per hour of company");
                int empRatePerHr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter max working days of company");
                int maxWorkingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter max working hour of company");
                int maxWorkingHrs = Convert.ToInt32(Console.ReadLine());
                empWageBuilderArray.addCompanyWage(CompanyName, empRatePerHr, maxWorkingDays, maxWorkingHrs);
            }
            //calling each company to compute seperate total wage
            empWageBuilderArray.computeEmpWageofEachCompany();
            Console.WriteLine("Enter company Name");
            string CompanyNameDict = Console.ReadLine();
            empWageBuilderArray.getTotalwage(CompanyNameDict);
        }
    }
}