using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class MathOperations
    {
        public void divid(int inputNum)
        {
            Console.WriteLine(inputNum + " / 2 -> " + inputNum / 2);
        }

        public void divid(int inputNum, out int outNum)
        {
            outNum=inputNum / 2;

        }

    }
}
