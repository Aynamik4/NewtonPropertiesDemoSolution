using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesÖvningDel2
{
    class Car
    {
        private string licenseNumber;
        public string LicenseNumber
        {
            set
            {
                //bool lengthOK = value.Length == 6;
                //bool digitsOK = false;

                //if (lengthOK)
                //    digitsOK = int.TryParse(value.Substring(3, 3), out int digits);

                //if (!digitsOK)
                //    throw new Exception("Three last characters must be digits 0-9");

                if (!(value.Length == 6 && int.TryParse(value.Substring(3, 3), out int digits)))
                    throw new Exception("Invalid license number");

                string letters = value.Substring(0, 3).ToUpper();

                for (int i = 0; i < letters.Length; i++)
                {
                    if (!("ABCDEFGHIJKLMNOPQRSYUVWXYZ".Contains(letters[i])))
                        throw new Exception("Three first characters must be letters A-Z");
                }

                if (letters == "FAN" || letters == "FUL" || letters == "FIS") // etc...
                    throw new Exception("Inappropriate letter combination");

                licenseNumber = value;
            }
            get
            {
                string letters = licenseNumber.Substring(0, 3);
                string digits = licenseNumber.Substring(3, 3);

                return $"*** {letters.ToUpper()} {digits} ***";
            }
        }

        private string color;
        public string Color
        {
            set
            {
                value = value.ToUpper();

                switch (value)
                {
                    case "RED":
                        color = value;
                        break;
                    case "GREEN":
                        color = value;
                        break;
                    case "BLUE":
                        color = value;
                        break;
                    case "YELLOW":
                        color = value;
                        break;
                    default:
                        throw new Exception("Ivalid color");
                }
            }
            get
            {
                string aColor = string.Empty;

                switch (color)
                {
                    case "RED":
                        aColor = "RÖD";
                        break;
                    case "GREEN":
                        aColor = "GRÖN";
                        break;
                    case "BLUE":
                        aColor = "BLÅ";
                        break;
                    case "YELLOW":
                        aColor = "GUL";
                        break;
                }

                return aColor;
            }
        }

    }
}
