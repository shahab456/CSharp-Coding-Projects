﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Employee:Person
    {
        public override string sayName()
        {
            return firstName + " " + lastName;
        }
    }
}
