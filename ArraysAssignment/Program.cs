using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1000,1001,1002,1003,1004,1005,1006,1007};
            string[] strArray = new string[] { "String0", "String1", "String2", "String3", "String4", "String5", "String6", "String7" };
            List<string> strList = new List<string>{ "String0", "String1", "String2", "String3", "String4", "String5", "String6", "String7" };
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine("You have 4 options (I -> Integer Array      S -> String Array     L -> String List     Q -> Quit");
                Console.WriteLine("Select an option(I/S/L/Q)");
                keyInfo = Console.ReadKey();
                //if (keyInfo.Key == ConsoleKey.Q) { break; }
                if (keyInfo.Key == ConsoleKey.I || keyInfo.Key == ConsoleKey.L || keyInfo.Key == ConsoleKey.S) {
                    Console.WriteLine("please input index: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    if (keyInfo.Key == ConsoleKey.I)
                    {
                        if (index >= intArray.Length) Console.WriteLine("index doesn’t exist");
                        else Console.WriteLine(intArray[index]);
                    }
                    else if (keyInfo.Key == ConsoleKey.S)
                    {
                        if (index >= strArray.Length) Console.WriteLine("index doesn’t exist");
                        else Console.WriteLine(strArray[index]);
                    }
                    else
                    {
                        if (index >= strList.Count) Console.WriteLine("index doesn’t exist");
                        else Console.WriteLine(strList[index]);
                    }
                }

            } while (keyInfo.KeyChar != 'Q' && keyInfo.KeyChar != 'q');
        }
    }
}
