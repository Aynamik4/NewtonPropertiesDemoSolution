using System;

namespace NewtonPropertiesDemoProject_03
{
    // Properties C# style... The superior way!
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
                    //me.SetAge(int.Parse(Console.ReadLine()));
                    me.Age = int.Parse(Console.ReadLine());
                    ageNotValid = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Felaktig ålder eller felaktigt format.");
                }
            }

            Console.WriteLine("Nu fortsätter programmet...");

            //Console.WriteLine(me.GetAge());
            Console.WriteLine(me.Age);
        }
    }
}
