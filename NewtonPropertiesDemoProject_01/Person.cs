using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonPropertiesDemoProject_01
{
    class Person
    {
        //.NET ver 4.? 2020
        public string Name0 { get; set; } // Automatic property.

        // .NET ver 1 år 2002.
        private string name; // Privat klassvariabel

        public string Name // Property.
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
