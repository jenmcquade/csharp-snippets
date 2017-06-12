using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Employee
    {
        public virtual void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            Console.WriteLine("\nThis ANGRY EMPLOYEE worked {0} hrs. " + 
                              "Paid for 40 hrs at $ {1}" +
                              "/hr = ${2} \n", weeklyHours, wage, salary);
            Console.WriteLine("---------------------------------------------\n");
        }
    }

    public class Contractor : Employee
    {
        public override void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            Console.WriteLine("\nThis HAPPY CONTRACTOR worked {0} hrs. " + 
                              "Paid for {0} hrs at $ {1}" +
                              "/hr = ${2} ", weeklyHours, wage, salary);
            Console.WriteLine("---------------------------------------------\n");
        }
    }


    public class Program
    {
        private static void Main(string[] args)
        {
            const int hours = 55, wage = 70;
            List<Employee> employees = GetEmployees();

            foreach (var e in employees)
            {
                e.CalculateWeeklySalary(hours, wage);
            }
        }

        private static List<Employee> GetEmployees()
        {
            var someEmployee = new Employee();
            var someContractor = new Contractor();
            var everyone = new List<Employee> { someEmployee, someContractor };
            return everyone;
        }
    }

}
