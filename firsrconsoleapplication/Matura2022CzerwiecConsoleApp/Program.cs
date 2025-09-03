using System.Diagnostics;

StreamReader steamreader = new StreamReader("przyklad.txt");

string strNumberFromFile;
List<string> strNumbers = new List<string>();

while ((strNumberFromFile = steamreader.ReadLine()) != null)
{
    strNumbers.Add(strNumberFromFile);
}

steamreader.Close();

// 4.1

Console.WriteLine("Zadanie 4.1");

var reverseDividedBy17 = strNumbers
    .Where(s => int.Parse(string.Join("", s.Reverse())) % 17 == 0)
    .Select(s => string.Join("", s.Reverse()));

foreach(var strNumber in reverseDividedBy17)
{
    Console.WriteLine(strNumber);
}

// 4.2 

Console.WriteLine("Zadanie 4.2");

int maxNumber = 0;
int maxDiff = 0;

for (int i = 0; i < strNumbers.Count; i++)
{
    int number = int.Parse(strNumbers[i]);
    int mirroredNumber = int.Parse(string.Join("", strNumbers[i].Reverse()));
    int dif = (Math.Abs(number - mirroredNumber));

    if (dif > maxDiff)
    {
        maxDiff = dif;
        maxNumber = number;
    }
}

Console.WriteLine($"{maxNumber} {maxDiff}");

// 4.3

Console.WriteLine("Zadanie 4.3");

List<int> numbers = strNumbers.Select(s => int.Parse(s)).ToList();
List<int> reverseNumbers = strNumbers.Select(s => int.Parse(string.Join("", s.Reverse()))).ToList();

bool checkIfPrime(int number)
{
    for (int i = 2; i < number; i++)
    {
        if ((number % i) == 0)
        {
            return false;
        }
    }
    return true;
}

for (int i = 0; i < numbers.Count(); i++)
{
    if (checkIfPrime(numbers[i]) && checkIfPrime(reverseNumbers[i]))
    {
        Console.WriteLine(numbers[i]);
    }
}



// 4.4

Console.WriteLine("Zadanie 4.4");

int countRepeats;
int countRepeatTwoTimes = 0;
int countRepeatThreeTimes = 0;

/*for(int i = 0; i < strNumbers.Count(); i++)
{
    countRepeats = 1;

    for (int j = i; j < strNumbers.Count(); j++)
    {
        if (int.Parse(strNumbers[i]) == int.Parse(strNumbers[j]))
            countRepeats++;
    }

    if (countRepeats == 2)
        countRepeatTwoTimes++;
    else if (countRepeats == 3)
        countRepeatThreeTimes++;
}

Console.WriteLine($"{strNumbers.Distinct().Count()} {countRepeatTwoTimes} {countRepeatThreeTimes}");
*/

var numberCounts = strNumbers.GroupBy(n => n).Select(g => g.Count());
Console.WriteLine(strNumbers.Where(g => g.Count() == 2));