using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations cls = new MathOperations();
            cls.DoMath(5, 8);

            cls.DoMath(num2: 4, num1: 6);

            Console.ReadKey();
        }
    }
}
