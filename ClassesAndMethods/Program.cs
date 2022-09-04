using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations cls = new MathOperations();
            Console.WriteLine("Please input a number:");
            string userNumber=Console.ReadLine();

            Console.WriteLine("\nOutput of operatin as Integer (Remainder to 3): " + cls.DoMath(Convert.ToInt32(userNumber)));
            
            Console.WriteLine("\nOutput of operatin as Decimal (Remainder to 5): " + cls.DoMath(Convert.ToDecimal(userNumber)));
            
            Console.WriteLine("\nOutput of operatin as String (Remainder to 7): " + cls.DoMath(userNumber));

            Console.ReadKey();
        }
    }
}
