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
int maxCountPrimeFactors = 0;
string maxNumberPrimeFactors = "";
int maxDiffCountPrimeFactors = 0;
string maxDiffNumberPrimeFactors = "";


foreach (string strNumber in strNumbers)
{
    int number = int.Parse(strNumber);
    int div = 2;

    List<int> primeFactors = new List<int>();
    while (number != 1)
    {
        
        if(number % div == 0)
        {
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
}

Console.WriteLine($"{maxNumberPrimeFactors} {maxCountPrimeFactors} {maxDiffNumberPrimeFactors} {maxDiffCountPrimeFactors}");

Console.WriteLine();

// zadanie 4.3

List<int> numbers = strNumbers.Select(strNumber => int.Parse(strNumber)).OrderBy(n => n).ToList();

for (int i = 0; i < numbers.Count; i++)
{
    for (int j = i+1; j < numbers.Count; j++)
    {
        if (numbers[j] % numbers[i] == 0 )
        {
            for (int k = j+1; k < numbers.Count; k++)
            {
                if (numbers[k] % numbers[j] == 0)
                {
                    for (int l = k+1; l < numbers.Count; l++)
                    {
                        if (numbers[l] % numbers[k] == 0)
                        {
                            for (int m = l+1; m < numbers.Count; m++)
                            {
                                if (numbers[m] % numbers[l] == 0)
                                {
                                    Console.WriteLine($"{numbers[i]} {numbers[j]} {numbers[k]} {numbers[l]} {numbers[m]}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}