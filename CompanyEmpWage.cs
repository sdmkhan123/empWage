using System;
using System.Collections.Generic;
using System.Text;

namespace empWage
{
    public class CompanyEmpWage
    {
        //declare instances of this class
        public string CompanyName;
        public int empRatePerHr;
        public int maxWorkingDays;
        public int maxWorkingHrs;
        public int totalEmpWage;
        //Declare a constructor to create  object of that type
        public CompanyEmpWage(string CompanyName, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            this.CompanyName = CompanyName;
            this.empRatePerHr = empRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        //to set total emp wage
        public void setTotalWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        //return total emp wage
        public string toShowWage()
        {
            return "Total emp wage of " + this.CompanyName + " company is " + this.totalEmpWage;
        }
    }
}
