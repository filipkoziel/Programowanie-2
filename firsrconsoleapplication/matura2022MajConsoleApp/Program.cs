// zadanie 4

using System.Diagnostics;

StreamReader steamreader = new StreamReader("przyklad.txt");

string strNumberFromFile;
List<string> strNumbers = new List<string>();

while ((strNumberFromFile = steamreader.ReadLine()) != null)
{
    strNumbers.Add(strNumberFromFile);
}

steamreader.Close();

// zadanie 4.1

int counter4_1 = strNumbers.Where(s => s[0] == s[s.Length - 1]).Count();
string firstNumber4_1 = strNumbers.First(s => s[0] == s[s.Length - 1]);
Console.WriteLine($"{counter4_1} {firstNumber4_1}");

Console.WriteLine();

// zadanie 4.2
int counter4_2 = 0;


foreach (string strNumber in strNumbers)
{
    Console.WriteLine(strNumber);
    int number = int.Parse(strNumber);
    int div = 2;
    int maxCountPrimeFactors = 0;
    string maxNumberPrimeFactors = "";
    int maxDiffCountPrimeFactors = 0;
    string maxDiffNumberPrimeFactors = "";

    List<int> primeFactors = new List<int>();
    while (number != 1)
    {
        
        if(number % div == 0)
        {
            Console.Write($"{div}, ");
            primeFactors.Add(div);
            number = number / div;
        }
        else
        {
            div++;
        }

    }

    if(primeFactors.Count() > maxCountPrimeFactors)
    {
        maxCountPrimeFactors = primeFactors.Count();
        maxNumberPrimeFactors = strNumber;
    }

    if (primeFactors.Distinct().Count() > maxDiffCountPrimeFactors)
    {
        maxDiffCountPrimeFactors = primeFactors.Count();
        maxDiffNumberPrimeFactors = strNumber;
    }

    Console.WriteLine();

    Console.WriteLine();
}

