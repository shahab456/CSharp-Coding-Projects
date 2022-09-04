using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            CreateEmployeeList(empList);
            Console.WriteLine(empList.Count);
            List<Employee> filteredList = new List<Employee>();
            foreach(Employee empl in empList)
            {
                if (empl.firstName == "Joe") filteredList.Add(empl);
            }

            List<Employee> lambdaList = new List<Employee>();
            lambdaList= empList.Where(w => w.firstName == "Joe" && w.id>5).ToList();

            Console.WriteLine("\nList created by foreach:\n-----------------------");
            foreach(Employee empl in filteredList) {
                Console.WriteLine("Id: "+empl.id);
                Console.WriteLine("First Name: "+empl.firstName);
                Console.WriteLine("Last Name: " + empl.lastName);
            }

            Console.WriteLine("\n**************************\n");
            Console.WriteLine("\nList created by lambda expression:\n-----------------------");
            foreach (Employee empl in lambdaList)
            {
                Console.WriteLine("Id: " + empl.id);
                Console.WriteLine("First Name: " + empl.firstName);
                Console.WriteLine("Last Name: " + empl.lastName);
            }

            Console.ReadKey();
        }

        public static void CreateEmployeeList(List<Employee> empList)
        {
            Employee empl;
            empl = new Employee();
            empl.id = 1;
            empl.firstName = "Bob";
            empl.lastName = "Smith";
            empList.Add(empl);

            empl = new Employee();
            empl.id = 2;
            empl.firstName = "Joe";
            empl.lastName = "Ronin";
            empList.Add(empl);
            
            empl = new Employee();
            empl.id = 3;
            empl.firstName = "Katy";
            empl.lastName = "Mikes";
            empList.Add(empl);

            empl = new Employee();
            empl.id = 4;
            empl.firstName = "Joe";
            empl.lastName = "Beiden";
            empList.Add(empl);

            empl = new Employee();
            empl.id = 5;
            empl.firstName = "William";
            empl.lastName = "Falkner";
            empList.Add(empl);

            empl = new Employee();
            empl.id = 6;
            empl.firstName = "Chris";
            empl.lastName = "Ronaldo";
            empList.Add(empl);

            empl = new Employee();
            empl.id = 7;
            empl.firstName = "Joe";
            empl.lastName = "Martin";
            empList.Add(empl);

            empl = new Employee();
            empl.id = 8;
            empl.firstName = "Silvester";
            empl.lastName = "Stalone";
            empList.Add(empl);

            empl = new Employee();
            empl.id = 9;
            empl.firstName = "Maria";
            empl.lastName = "Bond";
            empList.Add(empl);

            empl = new Employee();
            empl.id = 10;
            empl.firstName = "Sarah";
            empl.lastName = "Merkel";
            empList.Add(empl);
        }
    }
}
