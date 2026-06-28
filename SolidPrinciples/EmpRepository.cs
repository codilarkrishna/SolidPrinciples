using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class EmpRepository
    {
        public void SaveingData(Employee empData)
            => Console.WriteLine($"Saving {empData.Name} to database.");
    }
}
