using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssignment
{
    class Program
    {
        public struct Number
        {
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            Number myNum = new Number();
            myNum.Amount = 23.4m;

            Console.WriteLine(myNum.Amount);


        Console.ReadKey();
        }
    }
}
