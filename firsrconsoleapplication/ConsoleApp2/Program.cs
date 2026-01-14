int originalValue = Int32.Parse(Console.ReadLine());
int count200 = 0, count100 = 0, count50 = 0, count20 = 0, count10 = 0, remainder = 0;

void fun(ref int value, int denomination, ref int count)
{
    int numberOf = value / denomination;
    value -= denomination * numberOf;
    count += numberOf;
}

while (originalValue != 0)
{
    if (originalValue >= 200)
        fun(ref originalValue, 200, ref count200);
    else if (originalValue >= 100)
        fun(ref originalValue, 100, ref count100);
    else if (originalValue >= 50)
        fun(ref originalValue, 50, ref count50);
    else if (originalValue >= 20)
        fun(ref originalValue, 20, ref count20);
    else if (originalValue >= 10)
        fun(ref originalValue, 10, ref count10);
    else
    {
        remainder = originalValue;
        originalValue = 0;
    }
}

Console.WriteLine($"{count200}, {count100}, {count50}, {count20}, {count10}, {remainder}");