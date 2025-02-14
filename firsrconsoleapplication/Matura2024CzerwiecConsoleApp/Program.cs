void oddShortCut(int number)
{
    List<int> odds = new List<int>();
    int oddShort = 0;
    for (int i = 10; i<100; i++)
    {
        odds.Add(number % 10);
        number = (number / 10);
        odds = odds.Where(x => x % 2 != 0).ToList();
    }
    foreach (int i in odds)
    {
        Console.Write(i);
    }
}

int number = int.Parse(Console.ReadLine());

oddShortCut(number);

