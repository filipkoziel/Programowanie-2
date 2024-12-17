using System.ComponentModel;
using System.Runtime;
using System.Text.RegularExpressions;
using Egzamin;
int getNumberOfDiceFromUser()
{

    int diceNumber = 0;
    do
    {
        Console.WriteLine("Choose number of dice to throw from 3-10");
        string i = Console.ReadLine();
        if (!int.TryParse(i, out diceNumber))
            diceNumber = 0;
    } while (!(diceNumber < 11 && diceNumber > 2));
    return diceNumber;
}
List<Dice> rollTheDice(int rolls, ref List<Dice> dices)
{
    Random rnd = new Random();
    for (int i = 0; i < rolls; i++)
    {
        var dice = new Dice(0, 0);
        dice.DiceNumber = i + 1;
        dice.DiceValue = rnd.Next(1,7);
        dices.Add(dice);
    }
    return dices;
}

int calculatePoints(List<Dice> dices)
{
    int points = 0;

    var reapeatingDice = dices.GroupBy(n => n.DiceValue).Where(g => g.Count() > 1);
    foreach(var group in reapeatingDice)
    {
        points = points + group.Sum(g => g.DiceValue);
    }

    return points;
}

string repeatAgain = "";

int numberOfDice = getNumberOfDiceFromUser();

do
{
    List<Dice> dice = new List<Dice>();

    rollTheDice(numberOfDice, ref dice);

    foreach (Dice element in dice)
    {
        element.writeRolls(dice);
    }

    Console.WriteLine(calculatePoints(dice));

    do
    {
        Console.WriteLine("Repeat game?");
        repeatAgain = Console.ReadLine();
    } while (repeatAgain != "t" && repeatAgain != "n");

} while (repeatAgain == "t");

return 0;