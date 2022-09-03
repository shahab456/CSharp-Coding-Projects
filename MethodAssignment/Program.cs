using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a Number: ");
            int num= Convert.ToInt32(Console.ReadLine());
            MyClass cls = new MyClass();
            Console.WriteLine("\nFactorial: "+cls.factorial(num));
            Console.WriteLine("\nSum of all numbers from 1: "+cls.sumTo(num));
            Console.WriteLine("\nNearest Number dividable to 3: "+cls.nearest3Dividable(num));

            Console.ReadKey();
        }
    }
}
