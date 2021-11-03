using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class SaveTheTotalWage
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.ToString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.ToString());
        }
    }
}
