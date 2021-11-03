using System;

namespace EmpWageComputation
{
    internal class CompanyempWage 
    {
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;

        public CompanyempWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        internal void setTotalEmpWage(object p)
        {
            throw new NotImplementedException();
        }
    }
}