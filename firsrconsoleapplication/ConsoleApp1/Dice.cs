using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Egzamin
{
    internal class Dice
    {
        public int DiceNumber { get; set; }
        public int DiceValue { get; set; }
        public Dice(int diceNumber, int diceValue)
        {
            DiceNumber = diceNumber;
            DiceValue = diceValue;
        }
        public void writeRolls(List<Dice> dice)
        {
                Console.WriteLine($"Kostka {DiceNumber}: {DiceValue}");
        }
    }
}