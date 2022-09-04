using System;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input a Number:");
            string num= Console.ReadLine();
            File.WriteAllText("FileIOAssignment_logFile.txt", num);
            Console.WriteLine("File Created");
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
