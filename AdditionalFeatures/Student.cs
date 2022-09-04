using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Student
    {
        string _id = "";
        string _fName = "";
        string _lName = "";

        public Student(string id)
            : this(id, "", "")
        {

        }

        public Student(string id, string fName)
            : this(id, fName, "")
        {

        }

        public Student(string id, string fName, string lName)
        {

            _id = id;
            _fName = fName;
            _lName = lName;
        }
    }
}
