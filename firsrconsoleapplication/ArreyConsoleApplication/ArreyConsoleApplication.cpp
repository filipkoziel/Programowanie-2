#include <iostream>
#include <ctime>

using namespace std;

void taskBored()
{
    int numbers[100];

    for (int i = 0; i < 100; i++)
    {
        numbers[i] = i;
        cout << numbers[i] << ", ";
        if (i == 25 || i == 50 || i == 75)
        {
            cout << "\n";
        }
    }

    cout << "\n\n";
    srand(time(NULL));

    for (int i = 0; i < 100; i++)
    {
        for (int j = 0, memory = 0; j < 100; j++)
        {
            if (rand() % 2 == 0)
            {
                if (j != 99)
                {
                    memory = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = memory;
                }
                else
                {
                    memory = numbers[j];
                    numbers[j] = numbers[0];
                    numbers[0] = memory;
                }
            }
            if (rand() % 2 == 1)
            {
                if (j != 0)
                {
                    memory = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = memory;
                }
                else
                {
                    memory = numbers[j];
                    numbers[j] = numbers[99];
                    numbers[99] = memory;
                }
            }
        }
    }
    for (int i = 0; i < 100; i++)
    {
        cout << numbers[i] << ", ";
        if (i == 25 || i == 50 || i == 75)
        {
            cout << "\n";
        }
    }

    cout << "\n\n";
    int comparisonsCounter = 0, loopsCounter = 0;

    for (int counter = 1, memory = 0; counter > 0;)
    {
        loopsCounter++;
        counter = 0;
        for (int i = 0; i < 100; i++)
        {
            comparisonsCounter++;

            if (numbers[i] > numbers[i + 1] && numbers[99] != numbers[i])
            {
                memory = numbers[i + 1];
                numbers[i + 1] = numbers[i];
                numbers[i] = memory;
                counter++;
            }
        }
    }

    for (int i = 0; i < 100; i++)
    {
        cout << numbers[i] << ", ";
        if (i == 25 || i == 50 || i == 75)
        {
            cout << "\n";
        }
    }
    cout << "\n\nNumber of comparisons: " << comparisonsCounter << "\nNumber of loops: " << loopsCounter;

}

void task1()
{
    int numbers[5];

    for (int i = 0; i < 5; i++)
    {
        cout << "wprowadŸ liczbe\n";
        cin >> numbers[i];
    }

    cout << "\nwprowadzone liczby to:\n";

    for (int j = 0; j < 5; j++)
    {
        cout << numbers[j] << "\n";
    }
}

void minimumAndMaximum()
{
    const int SIZE_OF_ARRAY = 5;
    int numbers[SIZE_OF_ARRAY];

    const int UPPER_RANGE = 8;
    const int LOWER_RANGE = 5;

    srand(time(NULL));

    for (int i = 0; i < SIZE_OF_ARRAY; i++)
    {
        numbers[i] = rand() % (UPPER_RANGE - LOWER_RANGE + 1) + LOWER_RANGE;
    }

    // maximum
    int max = numbers[0];
    for (int i = 1; i < SIZE_OF_ARRAY; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }

    // minimum
    int min = numbers[0];
    for (int i = 1; i < SIZE_OF_ARRAY; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }

    cout << "min: " << min << "\n" << "max: " << max << "\n";

    // average
    int sum = 0;
    for (int i = 1; i < SIZE_OF_ARRAY; i++)
    {
        sum = sum + numbers[i];
    }

    double average = sum * 1.0 / SIZE_OF_ARRAY;
    cout << "avg: " << average << "\n";
}

// napisz program która wylicza iloœæ wyst¹pieñ danej liczby w tablicy.
void countHowMany()
{
    const int SIZE_OF_ARRAY = 10000;
    int numbers[SIZE_OF_ARRAY];

    const int UPPER_RANGE = 100;
    const int LOWER_RANGE = 0;

    srand(time(NULL));

    for (int i = 0; i < SIZE_OF_ARRAY; i++)
    {
        numbers[i] = rand() % (UPPER_RANGE - LOWER_RANGE + 1) + LOWER_RANGE;
    }

    cout << "\n\n";

    //wersja 1
    int counter = 0;
    for (int numbersFromRange = LOWER_RANGE; numbersFromRange <= UPPER_RANGE; numbersFromRange++)
    {
        for (int j = 0; j < SIZE_OF_ARRAY; j++)
        {
            if (numbers[j] == numbersFromRange)
            {
                counter++;
            }
        }
        cout << numbersFromRange << " occured " << counter << " times\n";
        counter = 0;
    }

    cout << "\n\n";

    // wersja 2
    int numbersOfOccurences[UPPER_RANGE - LOWER_RANGE + 1];
    for (int i = 0; i < UPPER_RANGE - LOWER_RANGE + 1; i++)
    {
        numbersOfOccurences[i] = 0;
    }

    for (int j = 0; j < SIZE_OF_ARRAY; j++)
    {
        numbersOfOccurences[numbers[j] - LOWER_RANGE]++;
    }

    for (int i = 0; i < UPPER_RANGE - LOWER_RANGE + 1; i++)
    {
        cout << i + LOWER_RANGE << " occured " << numbersOfOccurences[i] << " times\n";
    }
}



int main()
{
    taskBored();
}
