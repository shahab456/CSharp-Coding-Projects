using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class MyClass
    {
        public int factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++) fact *= i;
            return fact;
        }

        public int nearest3Dividable(int num)
        {
            return (num - num % 3);
        }

        public int sumTo(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++) sum += i;
            return sum;
        }

    }
}
