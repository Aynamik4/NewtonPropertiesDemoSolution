using System;

namespace NewtonPropertiesDemoProject_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Person you = new Person(30);
            Console.WriteLine(you.Age1);

            //you.Age2 = 30;
            //Console.WriteLine(you.Age2);
        }
    }
}
