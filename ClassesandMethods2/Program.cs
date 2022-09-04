using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations cls = new MathOperations();
            Console.WriteLine("Here we Find Remainder ");
            Console.WriteLine("Please input your Number (Required):");
            int num= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the second number(optional, by default 2):");
            string input2 =Console.ReadLine();

            if (input2 == "") {
                Console.WriteLine(num + " % 2 -> " + cls.DoMath(num).ToString());
            }
            else {
                int num2 = Convert.ToInt32(input2);
                Console.WriteLine(num + " % " + num2 + " -> " + cls.DoMath(num, num2).ToString());
            }

            Console.ReadKey();
        }
    }
}
