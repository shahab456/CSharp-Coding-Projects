using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
     class Employee : Person
    {
        public int Id { get; set; }


        public static bool operator ==(Employee empl1, Employee empl2)
        {
            if (empl1.Id == empl2.Id) return true;
            else return false;
        }

        public static bool operator !=(Employee empl1, Employee empl2)
        {
            if (empl1.Id == empl2.Id) return false;
            else return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var Empl2 = (Employee)obj;
            return (Id == Empl2.Id);

        }

        public override int GetHashCode()
        {
            return (Id).GetHashCode();
        }
    }
}
