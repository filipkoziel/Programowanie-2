using System.Runtime;
using System.Text.RegularExpressions;
using Egzamin;
int getNumberOfDiceFromUser()
{
    int i = 0;
    do
    {
        Console.WriteLine("Choose number of dice to throw from 3-10");
        i = Convert.ToInt32(Console.ReadLine());
    } while (!(i < 11 && i > 2));
    return i;
}
List<int> rollTheDice(int rolls)
{
    List<int> roll = new List<int>();
    Random rnd = new Random();
    for (int i = 0; i < rolls; i++)
    {
        roll.Add(rnd.Next(1,7));
    }
    return roll;
}
void writeRolls(List<int> roll)
{
    for (int i = 0; i < roll.Count; i++)
    {
        Console.WriteLine($"Kostka {i+1}: {roll[i]}");
    }
}
int calculatePoints(List<int> roll)
{
    roll = roll.GroupBy(i => roll.);


    return 0;
}


int numberOfDice = getNumberOfDiceFromUser();

List<Dice> dice = new List<Dice>();

List<int> rolls = rollTheDice(numberOfDice);

for (int i = 0; i < rolls.Count; i++)
{
    dice.Add(i + 1, rolls[i]);
}

writeRolls(rolls);

calculatePoints(rolls);