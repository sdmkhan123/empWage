using System;
using System.Collections.Generic;
using System.Text;

namespace empWage
{
    public class EmpWageBuilder
    {
        public const int fullTimePresent = 1;
        public const int partTimePresent = 2;
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWagesArray;
        //Declare a constructor to create  object of that type
        public EmpWageBuilder()
        {
            this.companyEmpWagesArray = new CompanyEmpWage[5];
        }
        //store the object of the class for each company inside array
        public void addCompanyWage(string CompanyName, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            companyEmpWagesArray[this.numOfCompany] = new CompanyEmpWage(CompanyName, empRatePerHr, maxWorkingDays, maxWorkingHrs);
            numOfCompany++;
        }

        public void computeEmpWageofEachCompany()
        {
            for(int i=0; i< numOfCompany; i++)
            {
                companyEmpWagesArray[i].setTotalWage(this.computeEmpWageofEachCompany(this.companyEmpWagesArray[i]));
                Console.WriteLine(companyEmpWagesArray[i].toShowWage());
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
            }
            //return total wage of that given comapany
            return totalWorkHr * companyEmpWage.empRatePerHr;
        }
    }
}