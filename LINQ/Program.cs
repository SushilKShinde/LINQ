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
            List<int> dataSource = new List<int> { 100, 15, 74, 32, 21, 35, 14 };

            var querySyntax = (from num in dataSource
                               where num >= 30 && num <= 80
                               orderby num
                               select num).ToList();

            var methodSyntax = dataSource.Where(num => num >= 30 && num <= 80).OrderBy(num => num).ToList();

            Console.WriteLine("Output by Query Syntax");
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nOutput by Method Syntax");
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            List<string> stringDataSource = new List<string> { "Sushil", "Aman", "Budhha", "Chatur", "Deboline" };

            var stringQuerySyntax = (from name in stringDataSource
                                     where name.Length > 6
                                     orderby name
                                     select name).ToList();    // o/p: Deboline

            var stringMethodSyntax = stringDataSource.Where(name => name.Length > 6).OrderBy(name => name).ToList(); // o/p: Deboline

            Console.WriteLine("\nStringQuerySyntax OrderBy and Where");

            foreach(var name in stringQuerySyntax)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nStringMethodSyntax OrderBy and where ");

            foreach (var name in stringMethodSyntax)
            {
                Console.WriteLine(name);
            }
        }
    }
}
