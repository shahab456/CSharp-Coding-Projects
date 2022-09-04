using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    public  class MathOperations
    {
        public  int DoMath(int num)
        {
            return num % 3;
        }

        public  int DoMath(decimal num)
        {
            return Convert.ToInt32(num % 5);
        }

        public  int DoMath(string num)
        {
            return (Convert.ToInt32(num) % 7);
        }
    }

}
