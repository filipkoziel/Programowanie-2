#include <iostream>
#include <ctime>

using namespace std;

void taskBored()
{
    //wczytujemy 100 liczb do array i je mieszamy
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

int main()
{
    taskBored();
}
