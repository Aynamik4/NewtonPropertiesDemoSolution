using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonPropertiesDemoProject_02
{
    class Person
    {
        private int age;

        /// <summary>
        /// Sets the age of the instance.
        /// Exceptions: Throws an exception for values outside the range of 0 to 120.
        /// </summary>
        /// <param name="anAge">The age to set.</param>
        public void SetAge(int anAge)
        {
            if (anAge < 0 || anAge > 120) // Validering
                throw new Exception("Ålder måste vara mellan 0 och 120 år.");

            age = anAge;
        }

        public int GetAge()
        {
            return age;
        }
    }
}
