using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee();
            empl.FirstName = "Sample";
            empl.LastName = "Student";
            empl.SayName();

            Console.ReadKey();
        }
    }
}
