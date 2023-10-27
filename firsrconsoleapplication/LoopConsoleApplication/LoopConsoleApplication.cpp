
#include <iostream>
#include <time.h>

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
    int numberFromUser, sum = 0, store;

    cout << "input number\n";
    cin >> numberFromUser;

    do
    {
        store = numberFromUser % 10;
        sum = sum + store;
        numberFromUser = numberFromUser / 10;
    } while (numberFromUser > 0);

    cout << "\n the sum of the digits of that number equals: " << sum;
}

// Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.) dopóki suma tych kwadratów nie przekroczy 1000.
void task2DoWhile()
{

}

int main()
{
    task2DoWhile();
}

