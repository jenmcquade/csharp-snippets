using Moq;
using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Employee
    {
        public virtual string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            string result = $"This ANGRY EMPLOYEE worked {weeklyHours} hrs. " +
                            $"Paid for 40 hrs at $ {wage}" +
                            $"/hr = ${salary}";
            Console.WriteLine("\n" + result + " \n");
            Console.WriteLine("---------------------------------------------\n");
            return result;
        }
    }

    public class Contractor : Employee
    {
        public override string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            string result = $"This HAPPY CONTRACTOR worked {weeklyHours} hrs. " +
                            $"Paid for {weeklyHours} hrs at $ {wage}" +
                            $"/hr = ${salary} ";
            Console.WriteLine("\n" + result + " \n");
            return result;
        }
    }



    public class Program
    {
        private static void Main(string[] args)
        {
            const int hours = 55, wage = 70;
            //List<Employee> employees = Utils.GetEmployees();

            var mock = new Mock<Utils>();
            mock.Setup(m => m.GetMockEmployees()).Returns(() =>
             new List<Employee> { new Contractor(), new Employee() });

            List<Employee> employees = mock.Object.GetMockEmployees();

            foreach (var e in employees)
            {
                e.CalculateWeeklySalary(hours, wage);
            }
        }        
    }

    public class Utils {
        //public static List<Employee> GetEmployees()
        //{
        //    var someEmployee = new Employee();
        //    var someContractor = new Contractor();
        //    var everyone = new List<Employee> { someEmployee, someContractor };
        //    return everyone;
        //}

        public virtual List<Employee> GetMockEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
