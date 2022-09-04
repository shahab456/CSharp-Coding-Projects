using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstSample
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }


    public class PersonContext: DbContext
    {
        public DbSet<Student> Students { get; set; }

    }
}
