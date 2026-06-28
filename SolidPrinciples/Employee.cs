using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class Employee
    {
        public string Name { get; set; }
        public decimal salary { get; set; }

        public decimal CalTax() => salary * 0.2m;
    }
}
