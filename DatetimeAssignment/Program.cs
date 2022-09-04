using System;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Now is: "+now);
            Console.WriteLine("Please input a number");
            int X=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("After "+X+" hours it will be: "+now.AddHours(X));
            Console.ReadKey();
        }
    }
}
