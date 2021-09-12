using System;
using System.Collections.Generic;
using System.Text;

namespace empWage
{
    public class EmpWageBuilder: InterfaceComputeWage
    {
        public const int fullTimePresent = 1;
        public const int partTimePresent = 2;
        private List<CompanyEmpWage> companyEmpWagesList;
        private Dictionary<string, CompanyEmpWage> companyEmpWagesMap;
        //Declare a constructor to create  object of that type
        public EmpWageBuilder()
        {
            this.companyEmpWagesList = new List<CompanyEmpWage>();
            this.companyEmpWagesMap = new Dictionary<string, CompanyEmpWage>();
        }
        //store the object of the class for each company inside array
        public void addCompanyWage(string CompanyName, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(CompanyName, empRatePerHr, maxWorkingDays, maxWorkingHrs);
            this.companyEmpWagesList.Add(companyEmpWage);
            this.companyEmpWagesMap.Add(CompanyName, companyEmpWage);
        }

        public void computeEmpWageofEachCompany()
        {
            for(int i=0; i< companyEmpWagesList.Count; i++)
            {
                Console.WriteLine("New Company wage");
                companyEmpWagesList[i].setTotalWage(this.computeEmpWageofEachCompany(this.companyEmpWagesList[i]));
                Console.WriteLine(companyEmpWagesList[i].toShowWage());
                
            }
        }
        private int computeEmpWageofEachCompany(CompanyEmpWage companyEmpWage)
        {
            //declare variable
            int empHr = 0;
            int day = 1;
            int totalWorkHr = 0;
            //compute emp wage
            while (day <= companyEmpWage.maxWorkingDays && totalWorkHr <= companyEmpWage.maxWorkingHrs)
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
                int dailyWage = companyEmpWage.empRatePerHr * empHr;
                Console.WriteLine("Daily wage of the company " + companyEmpWage.CompanyName + " is " + dailyWage);
            }
            //return total wage of that given comapany
            return totalWorkHr * companyEmpWage.empRatePerHr;
        }
        public void getTotalwage(string companyName)
        {
            Console.WriteLine("Total wage for " + companyName + "company is " + this.companyEmpWagesMap[companyName].totalEmpWage);
        }
    }
}