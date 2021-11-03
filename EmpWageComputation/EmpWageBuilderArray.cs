using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class EmpWageBuilderArray : EmpWageBuilderArrayBase
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfcompany = 0;
        private CompanyempWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyempWage[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfcompany] = new CompanyempWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfcompany++;
        }
        public void computeEmpWage(int numOfCompany)
        {
            for (int i = 0; i < numOfCompany; i++)
            {

                companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }

        private object ComputeEmpWage(CompanyempWage companyempWage)
        {
            throw new NotImplementedException();
        }

        internal void computeEmpWage()
        {
            throw new NotImplementedException();
        }
    }
}
