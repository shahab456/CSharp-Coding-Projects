using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input your age");

                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0) Console.WriteLine("Error: The age cannot be Negative or zero");
                else  Console.WriteLine("Your BirthYear was: " + DateTime.Now.AddYears(0 - age).Year);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            Console.ReadKey();
        }
    }
}
