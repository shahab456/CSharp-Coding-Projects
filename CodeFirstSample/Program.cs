using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.firstName = "Howard";
            student1.lastName = "Watson";
            PersonContext ctxt = new PersonContext();
            ctxt.Students.Add(student1);
            ctxt.SaveChanges();

            Console.WriteLine("Finished");
            Console.ReadKey();
    }
    }
}
