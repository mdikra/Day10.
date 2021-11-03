namespace EmpWageComputation
{
    internal class EmpWageBuilderArrayBase
    {
        private int ComputeEmpWage(CompanyempWage companyempWage)
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalworkingDays = 0;
            int maxHoursPerMonth = 0;
            int numOfWorkingDays = 0;
            //computation
            while (totalEmpHrs <= maxHoursPerMonth && totalworkingDays < numOfWorkingDays)
            {
                totalworkingDays++;
                Random random = new Random();
                int v = random.Next(0, 3);
                int empCheck = v;
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalworkingDays + " Emp Hrs : " + empHrs);
            }

        }
    }
}