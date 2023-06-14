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

            // Any method is used to check if at least one element of datasource satisfys the given condition
            // returns Boolean value
            // to check if data source contains any data or not

            List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 1 };

            bool res = numbers.Any();  // true
            Console.WriteLine(res);
            numbers.Sort();
            if(res)
            {
                foreach(int i in numbers)
                    Console.WriteLine(i);
            }

            var methodSyntax = numbers.Any(x => x > 8); 
            Console.WriteLine(methodSyntax);  // false

            var querySyntax = (from num in numbers
                               select num).Any(num => num > 8);
            Console.WriteLine(querySyntax);

        }
    
    }
}
