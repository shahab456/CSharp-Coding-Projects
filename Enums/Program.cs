using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    static void Main(string[] args)
        {
            WeekDays wd = new WeekDays();
            Console.WriteLine("enter the current day of the week");
            string userInput=Console.ReadLine();
            try {
                wd=(WeekDays)Enum.Parse(typeof(WeekDays),userInput);
                Console.WriteLine("\noutput: "+wd);
            }
            catch(Exception exp)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.WriteLine(exp.Message);
            }

            Console.ReadKey();
        }
    }
}
