using System;
using System.Collections.Generic;
using System.Text;

namespace empWage
{
    interface InterfaceComputeWage
    {
        public void addCompanyWage(string CompanyName, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs);
        public void computeEmpWageofEachCompany();
    }
}
