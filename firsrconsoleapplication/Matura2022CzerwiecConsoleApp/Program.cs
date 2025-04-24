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

var reverseDividedBy17 = strNumbers
    .Where(s => int.Parse(string.Join("", s.Reverse())) % 17 == 0)
    .Select(s => string.Join("", s.Reverse()));

Console.WriteLine("Zadanie 4.1");
foreach(var strNumber in reverseDividedBy17)
{
    Console.WriteLine(strNumber);
}

// 4.2 

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

Console.WriteLine("Zadanie 4.2");

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
            break;
        }
        if ((i + 1) == number)
        {
            return true;
        }
    }
    return false;
}

/*for (int i = 0; i < numbers.Count();i++)
{
    for(int j = 2;j < numbers[i];j++)
    {
        if (numbers[i] % j == 0 || reverseNumbers[i] % j == 0)
        {
            break;
        }
        else if (j+1 == numbers[i] && j + 1 == reverseNumbers[i])
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
*/
/*
for (int i = 0; i < numbers.Count(); i++)
{
    for (int j = 2; j < numbers.Max(); j++)
    {
        if ((numbers[i] % j) == 0 || (reverseNumbers[i] % j) == 0)
        {
            break;
        }
        else if ((j + 1) == numbers[i] && (j + 1) == reverseNumbers[i])
        {
            Console.WriteLine(numbers[i]);
        }
    }
}*/

Console.WriteLine(checkIfPrime(32));

// 4.4

Console.WriteLine("Zadanie 4.4");

int countRepeats = 0;
int countrepeat2s = 0;
int countrepeat3s = 0;

for(int i = 0; i < strNumbers.Count(); i++)
{
    for(int j = 0; j < strNumbers.Count(); j++)
    {
        if (int.Parse(strNumbers[i]) == int.Parse(strNumbers[j]))
            countRepeats++;
        // aktualnie, dwa razy sprawdza 
    }
    if (countRepeats == 2)
        countrepeat2s++;
    else if (countRepeats == 3)
        countrepeat3s++;

    countRepeats = 0;
}

Console.WriteLine($"{strNumbers.Distinct().Count()} {countrepeat2s} {countrepeat3s}");