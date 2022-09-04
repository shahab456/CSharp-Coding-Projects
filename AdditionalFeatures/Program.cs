using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            const string var1= "ConstVar";
            var var2 = 45.67;
            Student stdnt = new Student("3", "Shahab", "molouk");

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.ReadKey();
        }
    }
}
