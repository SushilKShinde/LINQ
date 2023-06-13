using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Employee
    {
        public int empId { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public List<Techs> programming { get; set; }
    }

    public class Techs
    {
        public string technology { get; set; }
    }
}
