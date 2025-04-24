using System.Collections.Generic;
using System.Globalization;

int oddShortCut(int number)
{
    List<int> odds = new List<int>();
    int result = 0;
    for (int i = 10; i<100; i++)
    {
        if((number % 10) % 2 != 0)
            odds.Add(number % 10);
        number = (number / 10);
    }

    odds.Reverse();

    foreach (int digit in odds)
    {
        result = 10 * result + digit;
    }

    return result;
}

// 3.2 

Console.WriteLine("\nZad 3.2");

StreamReader steamreader = new StreamReader("skrot.txt");

string strNumberFromFile;
List<string> strNumbers = new List<string>();

while ((strNumberFromFile = steamreader.ReadLine()) != null)
{
    strNumbers.Add(strNumberFromFile);
}
steamreader.Close();


int maxImpossibleNumber = 0;
int countImpossibleNumbers = 0;
foreach (string strNumber in strNumbers)
{
    int number = int.Parse(strNumber);
    if (oddShortCut(number) == 0)
    { 
        countImpossibleNumbers++;
        if (number > maxImpossibleNumber)
            maxImpossibleNumber = number;
    }

}

Console.WriteLine($"Liczb które nie mają nieparzystego skrutu jest: {countImpossibleNumbers}, a najwięszą z nich jest: {maxImpossibleNumber}");

// 3.3

Console.WriteLine("\nZad 3.3");

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



turkyie
