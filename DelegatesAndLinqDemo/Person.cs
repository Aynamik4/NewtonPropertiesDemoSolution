using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndLinqDemo
{
    class Person
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public int Age
        {
            get { return DateTime.Now.Year - BirthYear; }
        }

    }
}
