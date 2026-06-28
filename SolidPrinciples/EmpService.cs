using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class EmpService
    {
        // somethng like this
        // check if the employee is valid or not
        public void DisplayData(Employee employee)
            => Console.WriteLine($"Something {employee.Name}....");
    }
}
