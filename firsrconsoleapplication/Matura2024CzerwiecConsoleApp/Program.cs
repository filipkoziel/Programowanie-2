void oddShortCut(int number)
{
    int oddShort = 0;
    for (int i = 10; i<10000000; i=i*10)
    {
        Console.WriteLine(number / i);
    }
}

int number = int.Parse(Console.ReadLine());

oddShortCut(number);

