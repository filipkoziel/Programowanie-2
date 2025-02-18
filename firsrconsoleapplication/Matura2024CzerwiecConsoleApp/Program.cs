string oddShortCut(int number)
{
    List<int> odds = new List<int>();
    int oddShort = 0;
    for (int i = 10; i<100; i++)
    {
        odds.Add(number % 10);
        number = (number / 10);
        odds = odds.Where(x => x % 2 != 0).ToList();
    }
    string result = String.Join("", odds);

    return result;
}

int testNumber = int.Parse(Console.ReadLine());

// 3.1 oddShortCut

Console.WriteLine($"{testNumber} - {oddShortCut(testNumber)}");

// 3.2 

StreamReader steamreader = new StreamReader("skrot.txt");

string strNumberFromFile;
List<int> numbers = new List<int>();

while ((strNumberFromFile = steamreader.ReadLine()) != null)
{
    numbers.Add(int.Parse(strNumberFromFile));
}
steamreader.Close();

foreach (int number in numbers)
{
    int maxnumber = 0;
    int countImpossible = 0;
    int oddShortNumber = int.Parse(oddShortCut(number));

    if (oddShortNumber == 0)
        countImpossible++;
    if (oddShortNumber )

}