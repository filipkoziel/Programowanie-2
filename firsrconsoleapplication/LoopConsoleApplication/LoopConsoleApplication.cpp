
#include <iostream>
#include <time.h>
#include <cmath>

using namespace std;

/*

DO-WHILE
* Napisz program, który policzy sumę cyfr podanej przez użytkownika liczby.
* Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.) dopóki suma tych kwadratów nie przekroczy 1000.

WHILE
* Miasto T. ma obecnie 100 tys. mieszkańców, ale jego populacja rośnie co roku o 3% rocznie. Miasto B. ma 300 tys. mieszkańców i ta liczba rośnie w tempie 2% na rok. Wykonaj symulację prezentującą liczbę mieszkańców w obu miastach i zatrzymującą się, gdy liczba mieszkańców miasta T. przekroczy liczbę z miasta B.
* Napisz program, który poprosi użytkownika o wprowadzenie dowolnej liczby całkowitej. Następnie program powinien obliczyć i wyświetlić liczbę cyfr.
* Program sprawdzający czy podana liczba jest liczbą doskonałą (czyli taką, której suma dzielników (z wyłączeniem samej siebie) jest równa danej liczbie, np. 6 jest liczbą doskonałą, ponieważ 1 + 2 + 3 = 6).

FOR
* Program wyświetlający na ekranie kolejne liczby naturalne od 1 do 10
* Program obliczający sumę liczb od 1 do 100
* Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.)
* Program obliczający n!.
* Program wyświetlający na ekranie silnie z liczb od 1 do 10 (np. 1!, 2!, 3!, 4! itd.)
* Program wyświetlający na ekranie tabliczkę mnożenia od 1 do 9 (np. 1x1=1, 1x2=2, 1x3=3 itd.).
* Program wyświetlający na ekranie wszystkie liczby podzielne przez 3 z zakresu od 1 do 100
* Program obliczający sumę kwadratów liczb od 1 do 10
* Program wyświetlający na ekranie ciąg Fibonacciego do 20 elementu (ciąg Fibonacciego to ciąg gdzie każdy element jest sumą dwóch poprzednich, np. 0, 1, 1, 2, 3, 5, 8, 13 itd.)
* Program, kóry wyświetli poniższe cztery zwory:
    ****       54321        121212        122333
    ***        65432        212121        223334444
    **         76543        121212        333444455555
    *          87654        212121        444455555666666

* Oblicz sumę szeregu 1/1^2 + 1/2^2 + 1/3^2 + ... +1/n^2. Jeżeli się nie pomylisz, to dla odpowiednio dużej wartości n po przemnożeniu jej przez 6 i spierwiastkowaniu powinieneś otrzymać wartość liczby π (suma szeregu jest równa π2/6). Zwróć uwagę, że pierwsza wartość indeksu to 1, a nie 0. Dokładność obliczeń można sprawdzić porównując z wartością odczytaną z własności Math.PI.

*/

void task1()
{
    int number;

    do
    {
        cout << "wprowadź liczbe\n";
        cin >> number; 
    } while (number != 0);
}

void task2()
{
    int a, b;
    cout << "wprowadź pierwszą liczbe\n";
    cin >> a;
    cout << "wprowadź drugą liczbe\n";
    cin >> b;

    while (b != 0)
    {
        int tmp = b;    
        b = a % b;
        a = tmp;
    }

    cout << "NWD: " << a << "\n";
}

void task3()
{
    int number;
    cout << "wprowadź numer\n";
    cin >> number;
    cout << "\n";

    for (int i = 0; i < number; i++)
    {
        cout << i + 1 << "\n";  
    }
}

void task4()
{
  
    srand(time(NULL));
    int secretNumber = rand() % 10;

    int number;
    do
    {
        std::cout << "Zgadnij liczbe:\n";
        std::cin >> number;
    } while (number != secretNumber);
    std::cout << "Gratulacje\n";
}



// ZADANIA
// DO-WHILE

// Napisz program, który policzy sumę cyfr podanej przez użytkownika liczby.
void task1DoWhile()
{
    int numberFromUser, sum = 0, storage;

    cout << "input number\n";
    cin >> numberFromUser;

    do
    {
        storage = numberFromUser % 10;
        sum = sum + storage;
        numberFromUser = numberFromUser / 10;
    } while (numberFromUser > 0);

    cout << "\n the sum of the digits of that number equals: " << sum;
}

// Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.) dopóki suma tych kwadratów nie przekroczy 1000.
void task2DoWhile()
{
    double sum = 0, numberSquared, number = 1;

    do
    {
        cout << number << " squared is: ";
        sum = sum + pow(number, 2);
        numberSquared = pow(number, 2);
        cout << numberSquared;
        number++;

        cout << "       (sum of all squares to this point is: " << sum << ")\n";
    } while (sum < 1000);
}




// ZADANIA 
// WHILE

// Miasto T. ma obecnie 100 tys. mieszkańców, ale jego populacja rośnie co roku o 3% rocznie. Miasto B. ma 300 tys. mieszkańców i ta liczba rośnie w tempie 2% na rok. Wykonaj symulację prezentującą liczbę mieszkańców w obu miastach i zatrzymującą się, gdy liczba mieszkańców miasta T. przekroczy liczbę z miasta B.
void task1While()
{
    double populationOfT = 100000, populationOfB = 300000;

    while (populationOfB > populationOfT)
    {
        populationOfB = populationOfB + populationOfB  * 0.02;
        populationOfT = populationOfT + populationOfT * 0.03;

        cout << "populacja miasta B: " << populationOfB << "\npopulacja miasta T: " << populationOfT << "\n";
    }
}

//Napisz program, który poprosi użytkownika o wprowadzenie dowolnej liczby całkowitej. Następnie program powinien obliczyć i wyświetlić liczbę cyfr.
void task2While()
{
    int numberFromUser, numberOfDigits = 0;

    cout << "input an integer\n";
    cin >> numberFromUser;

    while (numberFromUser > 0)
    {
        numberFromUser = numberFromUser / 10;
        numberOfDigits++;
    }

    cout << "the number of digits is: " << numberOfDigits;
}

// Program sprawdzający czy podana liczba jest liczbą doskonałą (czyli taką, której suma dzielników (z wyłączeniem samej siebie) jest równa danej liczbie, np. 6 jest liczbą doskonałą, ponieważ 1 + 2 + 3 = 6).
void task3While()
{
    int numberFromUser, number = 1, sum = 0;

    cout << "input an integer\n";
    cin >> numberFromUser;

    while (numberFromUser > number)
    {
        if (numberFromUser % number == 0)
        {
            sum = sum + number;
        }
        number++;
    }

    if (sum == numberFromUser)
    {
        cout << "The number is a perfect number\n";
    }
    else
    {
        cout << "the number wasn't a perfect number\n";
    }
}




// ZADANIA
// FOR

// Program wyświetlający na ekranie kolejne liczby naturalne od 1 do 10
void task1For()
{
    for (int i = 1; i <= 10; i++)
    {
        cout << i << "\n";
    }
}

// Program obliczający sumę liczb od 1 do 100
void task2For()
{
    for (int i = 1, sum = 0; i <= 100; i++)
    {
        cout << sum << " + " << i << " = ";
        sum = sum + i;
        cout << sum << "\n";
    }   
}

// Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.)
void task3For()
{
    for (int i = 1; i <= 10; i++)
    {
        cout << i << " ^ 2 = " << pow(i, 2) << "\n";
    }
}

// Program obliczający n!
void task4For()
{
    int numberFromUser, factorial = 1;

    cout << "input a number\n";
    cin >> numberFromUser;

    for (int i = 1; i <= numberFromUser; i++)
    {
        factorial = factorial * i;
    }
    cout << numberFromUser << " factorial is: " << factorial << "\n";
}

int main()
{
    task4For();
}

