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
            List<int> dataSource = new List<int> { 100, 15, 74, 32, 21, 32, 14 };

            var querySyntax = (from num in dataSource
                               orderby num
                               select num).ToList();

            var methodSyntax = dataSource.OrderBy(num => num).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
        }
    }
}
