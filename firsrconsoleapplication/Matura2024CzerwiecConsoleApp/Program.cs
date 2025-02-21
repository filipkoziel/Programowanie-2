using System.Collections.Generic;
using System.Globalization;

int oddShortCut(int number)
{
    List<int> odds = new List<int>();
    int oddShort = 0;
    int result = 0;
    for (int i = 10; i<100; i++)
    {
        odds.Add(number % 10);
        number = (number / 10);
    }

    odds = odds.Where(x => x % 2 != 0).Reverse().ToList();

    foreach (int digit in odds)
    {
        result = 10 * result + digit;
    }

    return result;
}



// 3.1 oddShortCut

//int testNumber = int.Parse(Console.ReadLine());

//Console.WriteLine($"{testNumber} - {oddShortCut(testNumber)}");

// 3.2 

StreamReader steamreader = new StreamReader("skrot.txt");

string strNumberFromFile;
List<string> strNumbers = new List<string>();

while ((strNumberFromFile = steamreader.ReadLine()) != null)
{
    strNumbers.Add(strNumberFromFile);
}
steamreader.Close();


int maxImpossibleNumber = 0;
int countImpossible = 0;
foreach (string strNumber in strNumbers)
{
    int number = int.Parse(strNumber);
    if (oddShortCut(number) == 0)
    { 
        countImpossible++;
        if (number > maxImpossibleNumber)
            maxImpossibleNumber = number;
    }

}

Console.WriteLine($"Liczb które nie mają nieparzystego skrutu jest: {countImpossible}, a najwięszą z nich jest: {maxImpossibleNumber}");

// 3.3

StreamReader steamreader2 = new StreamReader("skrot2.txt");

string strNumberFromFile2;
List<string> strNumbers2 = new List<string>();

while ((strNumberFromFile2 = steamreader2.ReadLine()) != null)
{
    strNumbers2.Add(strNumberFromFile2);
}
steamreader2.Close();


foreach (string strNumber2 in strNumbers2)
{
    int number = int.Parse(strNumber2);
    int a = number;
    int b = oddShortCut(number);
    int temp;
    while (b != 0)
    {
        temp = b;
        b = a % b;
        a = temp;
    }
    if (a == 7)
    Console.WriteLine(number);
}
