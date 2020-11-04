using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesÖvningDel1
{
    class Car
    {
        private string licenseNumber;
        private string color;

        public string GetLicenseNumber()
        {
            string letters = licenseNumber.Substring(0, 3);
            string digits = licenseNumber.Substring(3, 3);

            return $"*** {letters.ToUpper()} {digits} ***";
        }

        public void SetLicenseNumber(string licNumb)
        {
            //bool lengthOK = licNumb.Length == 6;
            //bool digitsOK = false;

            //if (lengthOK)
            //    digitsOK = int.TryParse(licNumb.Substring(3, 3), out int digits);

            //if (!digitsOK)
            //    throw new Exception("Three last characters must be digits 0-9");

            if (!(licNumb.Length == 6 && int.TryParse(licNumb.Substring(3, 3), out int digits)))
                throw new Exception("Invalid license number");

            string letters = licNumb.Substring(0, 3).ToUpper();

            for (int i = 0; i < letters.Length; i++)
            {
                if(!("ABCDEFGHIJKLMNOPQRSYUVWXYZ".Contains(letters[i])))
                    throw new Exception("Three first characters must be letters A-Z");
            }

            if (letters == "FAN" || letters == "FUL" || letters == "FIS") // etc...
                throw new Exception("Inappropriate letter combination");

            licenseNumber = licNumb;
        }

        public void SetColor(string aColor)
        {
            aColor = aColor.ToUpper();

            switch (aColor)
            {
                case "RED":
                    color = aColor;
                    break;
                case "GREEN":
                    color = aColor;
                    break;
                case "BLUE":
                    color = aColor;
                    break;
                case "YELLOW":
                    color = aColor;
                    break;
                default:
                    throw new Exception("Ivalid color");
            }

        }

        public string GetColor()
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
