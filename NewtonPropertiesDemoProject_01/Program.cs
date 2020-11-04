using System;

namespace NewtonPropertiesDemoProject_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person meMyself = new Person();
            meMyself.Name = "Håkan";
            string s = meMyself.Name;
            meMyself.Age = 58;
        }
    }
}
