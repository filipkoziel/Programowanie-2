using System;
using System.Collections.Generic;
using System.Text;

namespace EgzaminINF042026
{
    public class Kosc
    {
        public static int NumberOfDice;
        public List<string> imageNames = new List<string>(["kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png"]);
        public int numberThrown;
        public int imageFileIdentifier;
        bool isAvailable;

        public Kosc(int number)
        {
            if (!((int[])[1, 2, 3, 4, 5, 6]).Contains(number))
            {
                number = 0;
            }
            numberThrown = number;
            imageFileIdentifier = number;
            isAvailable = true;
            NumberOfDice++;
        }

        public Kosc()
        {
            Random rnd = new Random();
            int number = rnd.Next(1,6);
            numberThrown = number;
            imageFileIdentifier = number;
            isAvailable = true;
            NumberOfDice++;
        }

        public void throwDiceIfAvailable()
        {
            if (isAvailable)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 6);
                numberThrown = number;
                imageFileIdentifier = number;
            }
        }

        public void disableDice()
        {
            isAvailable = false;
        }

        public string thrownNumberToWord()
        {
            switch(numberThrown)
            {
                case 1: return "one";
                case 2: return "dwa";
                case 3: return "trzy";
                case 4: return "cztery";
                case 5: return "pięć";
                case 6: return "sześć";
                default: return "zero";
            }
        }
    }
}
