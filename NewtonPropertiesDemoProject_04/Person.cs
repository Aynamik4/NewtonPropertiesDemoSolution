using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonPropertiesDemoProject_04
{
    class Person
    {
        public int Age1 { get; private set; } // Automatic property.
        //public int Age2; // Public class variable.

        public Person(int anAge)
        {
            Age1 = anAge;
        }
    }
}
