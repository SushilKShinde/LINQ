using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the linq concept");

            var dataSource = new List<Employee>
            {
                new Employee
                {
                    empId = 2,
                    email = "sushil@gmail.com",
                    name = "Sushil"
                },

                new Employee
                {
                    empId = 3,
                    email = "Aman@gmail.com",
                    name = "Aman"
                },

                new Employee
                {
                    empId = 1,
                    email = "Chatur@hotmail.com",
                    name = "Chatur"
                },

                new Employee
                {
                    empId = 4,
                    email = "Bhagya@hotmail.com",
                    name = "Bhagya"
                }

            };
            

            var querySyntax = (from emp in dataSource
                              orderby emp.name
                              select emp).ToList();

            var methodSyntax = dataSource.Where(emp => emp.empId >= 3).OrderBy(emp => emp.name).ToList();

            foreach(var emp in methodSyntax)
            {
                Console.WriteLine(emp.name);
            }
        }
    }
}
