using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee();
            empl.firstName = "Sample";
            empl.lastName= "Student";
            Console.WriteLine(empl.sayName());
            Console.ReadKey();
       
        }
    }
}
