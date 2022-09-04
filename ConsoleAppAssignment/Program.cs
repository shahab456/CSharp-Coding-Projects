using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            List<string> strList = new List<string> { "zero","one", "two", "three", "four", "five", "six", "seven","eight","nine","ten" };
            List<string> strList2 = new List<string> { "JavaScript", "Python", "VisualBasic", "Java", "Html", "Python"};

            Console.WriteLine("Please input some text:");
            string userStr = Console.ReadLine();
            for(int i = 0; i < strArray.Length; i++) {
                strArray[i] += "_"+userStr;
            }
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }
            Console.WriteLine("\n");
            //infinite loop
            for(int i=0; ; i++)
            {
                if (i >= strArray.Length) break;
                Console.Write(strArray[i] + "\t");
            }
            Console.WriteLine("\n");
            //a loop with < comparison 
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }
            Console.WriteLine("\n");
            //a loop with <= comparison 
            for (int i = 0; i <= strArray.Length-1; i++)
            {
                Console.WriteLine(strArray[i]);
            }
            
            Console.WriteLine("\n");
            Console.WriteLine("Please input a text to search within my list:");
            string searchStr = Console.ReadLine();
            for(int i = 0; i < strList.Count; i++)
            {
                if (strList[i]==searchStr) { 
                    Console.WriteLine("index: " + i + " --> " + strList[i]);
                    break;
                }
                else if(i==strList.Count-1)Console.WriteLine("Not found in list");
            }
            // list with identical
            Console.WriteLine("\n");
            Console.WriteLine("Please input a text to search within my list:");
            string searchStr2 = Console.ReadLine();
            int found = 0;
            for (int i = 0; i < strList2.Count; i++)
            {
                if (strList2[i]== searchStr2)
                {
                    Console.WriteLine("index: " + i + " --> " + strList2[i]);
                    found = found + 1;
                }
            }
            if (found==0) Console.WriteLine("Not found in list");
            
            Console.WriteLine("\n");
            List<string> tmpList = new List<string>();
            foreach(string str in strList2)
            {
                if(tmpList.Contains(str))Console.WriteLine(str+ " -> already appeared ");
                else Console.WriteLine(str + " -> not appeared ");
                tmpList.Add(str);
            }
            Console.ReadKey();
        }
    }
}