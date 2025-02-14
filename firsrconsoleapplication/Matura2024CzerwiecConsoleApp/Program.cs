void oddShortCut(int number)
{
    int oddShort = 0;
    for (int i = 10; i<20; i++)
    {
        number = number / 10;
        Console.WriteLine(number);
    }
}

int number = int.Parse(Console.ReadLine());

oddShortCut(number);

