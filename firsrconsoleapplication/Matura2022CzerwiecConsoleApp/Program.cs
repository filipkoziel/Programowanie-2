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

List<int> absoluteDiffrenceFromReverse = new List<int>();

for (int i = 0; i < strNumbers.Count; i++)
{
    int number = int.Parse(strNumbers[i]);
    int mirroredNumber = int.Parse(string.Join("", strNumbers[i].Reverse()));
    absoluteDiffrenceFromReverse.Add(Math.Abs(number - mirroredNumber));
}

int maxAbsoluteDiffrence = absoluteDiffrenceFromReverse.Max();

Console.WriteLine("Zadanie 4.2");

for (int i = 0; i < strNumbers.Count; i++)
{
    if (absoluteDiffrenceFromReverse[i] == maxAbsoluteDiffrence)
    {
        Console.WriteLine($"{strNumbers[i]} - {absoluteDiffrenceFromReverse[i]}");
    }
}

// nie wiem co dalej

// 4.3

Console.WriteLine("Zadanie 4.3");

List<bool> isPrime = new List<bool>();

foreach (string strNumber in strNumbers)
{
    int number = int.Parse(strNumber);
    for(int i = 2;i < number;i++)
    {
        if (number % i == 0)
        {
            isPrime.Add(true);
            break;
        }
        else if (i+1 == number)
        {
            isPrime.Add(false);
        }
    }
}

// 