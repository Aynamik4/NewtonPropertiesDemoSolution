using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesAndLinqDemo
{
    class Program
    {
        static bool OfAge(Person p)
        {
            bool myndig = p.Age >= 18;
            return myndig;
        }

        static void AnyMethod(string s)
        {

        }

        static void Main(string[] args)
        {
            string name = "Håkan";
            AnyMethod("Håkan");
            AnyMethod(name);
            AnyMethod(Console.ReadLine());

            List<Person> people = new List<Person>()
            {
                new Person { Name = "Håkan", BirthYear = 1962 },
                new Person { Name = "Marilyn", BirthYear = 1976 },
                new Person { Name = "Nathalie", BirthYear = 2006 },
                new Person { Name = "Kenneth", BirthYear = 2009 }
            };

            var resultSet = people
                //.Where(OfAge); // Named Method

                .Where(p => p.Age >= 18); // Lambda expression

            foreach (Person aPerson in resultSet)
            {
                Console.WriteLine($"{aPerson.Name} {aPerson.Age}");
            }

            //var resultSet = people
            //    .Where(OfAge)
            //    .OrderBy(p => p.Age)
            //    .Select(p => $"{p.Name} {p.Age}");

            //foreach (string aPerson in resultSet)
            //{
            //    Console.WriteLine(aPerson);
            //}

            //List<string> phoneNumbers = new List<string>()
            //{
            //    "08-123 45 61",
            //    "070 464 74 31",
            //    "031 444 67 87"
            //};

            //var q0 = phoneNumbers
            //    .Where(p => p.EndsWith('1'))
            //    .ToList();

            //foreach (var item in q0)
            //{
            //    Console.WriteLine(item);
            //}


            //var q = from p in phoneNumbers
            //        where p.EndsWith('1')
            //        select p;

            //foreach (var item in q)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> pn = new List<string>();

            //foreach (string item in phoneNumbers)
            //{
            //    if (item.EndsWith('1'))
            //        pn.Add(item);
            //}

            //foreach (var item in pn)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
