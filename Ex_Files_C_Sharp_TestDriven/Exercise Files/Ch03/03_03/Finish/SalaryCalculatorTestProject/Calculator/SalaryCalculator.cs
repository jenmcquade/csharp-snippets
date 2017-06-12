using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            const int HoursInYear = 2080;
            decimal annualSalary = hourlyWage * HoursInYear;
            return annualSalary;
        }
    }
}
