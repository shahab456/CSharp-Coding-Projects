using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empl1 = new Employee();
            Employee empl2 = new Employee();

            empl1.Id = 2;
            empl1.FirstName = "Bob";
            empl1.LastName = "Smith";

            empl2.Id = 2;
            empl2.FirstName = "Bob";
            empl2.LastName = "Smith";

            if (empl1 == empl2) Console.WriteLine("Two Employee are same");
            else Console.WriteLine("Employees are not same");


            
            
            Console.ReadKey();
        }

        
    }
}
