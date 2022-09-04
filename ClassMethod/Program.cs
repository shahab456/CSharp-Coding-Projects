using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations cls = new MathOperations();
            int outNum;

            Console.Write("output1 is: ");
            
            cls.divid(367);
            
            cls.divid(988, out outNum);
            Console.WriteLine("output2 is:" +outNum);

            StaticClass.KeepWindowOpen();
        }
    }
}
