using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>{ 58, 36, 785, 104, 99, 3, 456, 12, 63 };
            try
            {
                Console.WriteLine("Type a number to divide list numbers: ");
                int divNum= Convert.ToInt32( Console.ReadLine());
                for(int i = 0; i < intList.Count; i++)
                {
                    Console.Write(intList[i] / divNum + "\t");
                }
                Console.WriteLine("\n");
            }
            catch(DivideByZeroException except)
            {
                Console.WriteLine("Divide by zero is unacceptable");
                Console.WriteLine(except.Message);
            }
            catch(System.FormatException except)
            {
                Console.WriteLine("you must input a number");
                Console.WriteLine(except.Message);
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally { 
                Console.WriteLine("Job Finished. Thanks!");
            }
            Console.ReadKey();
        }
    }
}
