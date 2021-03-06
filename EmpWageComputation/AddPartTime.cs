using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class AddPartTime
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empwage = 0;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empwage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empwage);
        }
    }
}
