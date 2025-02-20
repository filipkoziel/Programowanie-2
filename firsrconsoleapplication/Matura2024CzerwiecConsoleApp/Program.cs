using System.Collections.Generic;

int oddShortCut(int number)
{
    List<int> odds = new List<int>();
    int oddShort = 0;
    for (int i = 10; i<100; i++)
    {
        odds.Add(number % 10);
        number = (number / 10);
        odds = odds.Where(x => x % 2 != 0).ToList();
    }
    int result = 0;
    foreach (int entry in odds)
    {
        result = 10 * result + entry;
    }

    return result;
}

//int testNumber = int.Parse(Console.ReadLine());

// 3.1 oddShortCut

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

int maxnumber = 0;
int countImpossible = 0;
foreach (string strNumber in strNumbers)
{
    int number = int.Parse(strNumber);
    if (oddShortCut(number) == 0)
    { 
        countImpossible++;
        if (number > maxnumber)
            maxnumber = number;
    }

}

Console.WriteLine($"{countImpossible} - {maxnumber}");

// 3.2

