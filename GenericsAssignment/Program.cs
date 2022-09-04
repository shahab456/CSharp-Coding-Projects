using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> empl1= new Employee<string>();
            Employee<int> empl2 =new Employee<int>();
            empl1.id = 1;
            empl1.firstName = "Bob";
            empl1.lastName = "Smith";
            empl1.things =new List<string> { "BMW", "Ford" , "Volvo", "Toyota","Mitsubishi"};
            Console.WriteLine(empl1.id + ": " + empl1.firstName + " " + empl1.lastName);
            Console.WriteLine("\nthings\n------");
            for (int i = 0; i < empl1.things.Count; i++) Console.WriteLine(empl1.things[i]);

            Console.WriteLine("\n--------------------\n");
            empl2.id = 2;
            empl2.firstName = "Katy";
            empl2.lastName = "Jones";
            empl2.things =new List<int>{ 100,101,102,103,104,105,106};
            Console.WriteLine(empl2.id + ": " + empl2.firstName + " " + empl2.lastName);
            Console.WriteLine("\nthings\n------");
            for (int i = 0; i < empl2.things.Count; i++) Console.WriteLine(empl2.things[i]);

            Console.ReadKey();
        }
    }
}
