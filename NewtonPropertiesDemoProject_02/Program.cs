using System;
using System.Diagnostics;

namespace NewtonPropertiesDemoProject_02
{
    // Properties Java style...
    class Program
    {
        static void Main(string[] args) 
        {
            Person me = new Person();
            bool ageNotValid = true;

            while (ageNotValid)
            {
                try
                {
                    me.SetAge(int.Parse(Console.ReadLine()));
                    ageNotValid = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Felaktig ålder eller felaktigt format.");
                }
            }

            Console.WriteLine("Nu fortsätter programmet...");

            Console.WriteLine(me.GetAge());
        }
    }
}
