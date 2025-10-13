using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF04_2023_01.Data
{
    static class RandomCharacter
    {
        private static Random random = new Random();
        public static char GetLowercaseLetter()
        {
            return (char)random.Next('a', 'z' + 1);
        }
        public static char GetUppercaseLetter()
        {
            return (char)random.Next('A', 'Z' + 1);
        }
        public static char GetNumber()
        {
            return (char)random.Next('0', '9' + 1);
        }

        public static char GetSpecial()
        {
            string specialCharacters = "!@#$%^&*()_+-=";
            return specialCharacters[random.Next(0, specialCharacters.Length)];
        }
    }
}
