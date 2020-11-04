using System;

namespace PropertiesÖvningDel2 // Lösningsförslag.
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[100];
            int index = 0;
            bool addAnotherCar;

            do
            {
                cars[index++] = AddCar();
                Console.Write("\nLägg till ytterligare en bil (J/N)?: ");
                addAnotherCar = Console.ReadKey().Key == ConsoleKey.J;
                Console.WriteLine("\n");
            } while (addAnotherCar);

            for (int i = 0; i < index; i++)
            {
                var savedColor = Console.ForegroundColor;
                Console.Write($"Reg.nr.: {cars[i].LicenseNumber}. Färg: ");

                switch (cars[i].Color)
                {
                    case "RÖD":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "GRÖN":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "BLÅ":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "GUL":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }

                Console.WriteLine($"{cars[i].Color}");
                Console.ForegroundColor = savedColor;
            }
        }

        private static Car AddCar()
        {
            Car aCar = new Car();
            bool valid = false;
            string input = string.Empty;

            // Get license number.
            do
            {
                Console.Write("Ange registeringsnummer (Ex. AAA111): ");
                input = Console.ReadLine();

                try
                {
                    aCar.LicenseNumber= input;
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    valid = false;
                }
            } while (!valid);

            // Get color.
            do
            {
                Console.Write("Ange färg (Red, Green, Blue, Yellow): ");
                input = Console.ReadLine();

                try
                {
                    aCar.Color = input;
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    valid = false;
                }
            } while (!valid);

            return aCar;
        }
    }
}
