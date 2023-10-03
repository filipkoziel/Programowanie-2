#include <iostream>

using namespace std;

/*
1.
2. 
3. 
4. 
5. 
6. 
7. Program wyœwietlaj¹cy odpowiedni komunikat w zale¿noœci od podanej temperatury (np. "ciep³o" dla temperatury powy¿ej 20 stopni Celsjusza, "ch³odno" dla temperatury poni¿ej 10 stopni Celsjusza itd.)
*/


//Napisz funkcjê, która podzieli dwie liczby.
void task1()
{
    int firstNumber, secondNumber;

    cout << "Podaj pierwsz¹ liczbê:\n";
    cin >> firstNumber;
    cout << "Podaj drug¹ liczbê (byle nie zero):\n";
    cin >> secondNumber;

    if (secondNumber != 0)
    {
        double quotient = firstNumber / secondNumber;
        cout << "Wynik dzielenia: " << quotient << "\n";
    }
    else
    {
        cout << "Dzielenie przez zero!!!\n";
    }
}

//Program sprawdzaj¹cy czy podana liczba jest parzysta czy nieparzysta
void task2()
{
    int number;

    cout << "input number \n";
    cin >> number;

    if (number % 2 == 0)
        cout << "The number is even \n";
    else
        cout << "the number is odd \n";

}

//Program sprawdzaj¹cy czy podana liczba jest dodatnia, ujemna czy równa zero
void task3()
{
    int number;

    cout << "input number \n";
    cin >> number;

    if (number < 0)
        cout << "the number is negative \n";
    else if (number > 0)
        cout << "the number is positive \n";
    else
        cout << "the number is 0 \n";
}

//Program sprawdzaj¹cy czy podany rok jest rokiem przestêpnym
void task4()
{
    int year;

    cout << "input year \n";
    cin >> year;

    if (year % 4 == 0)
        cout << "leap year \n";
    else
        cout << "not a leap year \n";
}

//Program wyœwietlaj¹cy odpowiedni komunikat w zale¿noœci od podanej oceny (np. "bardzo dobry" dla oceny 5, "dobry" dla oceny 4 itd.)
void task5()
{
    int grade;

    cout << "podaj ocene \n";
    cin >> grade;

    if (grade == 1)
        cout << "niedostatesdzny \n";
    else if (grade == 2)
        cout << "dopuszczaj¹cy \n";
    else if (grade == 3)
        cout << "dostateczny \n";
    else if (grade == 4)
        cout << "dobry \n";
    else if (grade == 5)
        cout << "bardzo dobry \n";
    else if (grade == 6)
        cout << "celuj¹cy \n";
    else
        cout << "nie odpowiednia ocena \n";
}

//Program sprawdzaj¹cy czy podane has³o jest poprawne (np. jeœli has³o jest "abc123", program powinien wyœwietliæ "has³o poprawne", jeœli jest inne, powinien wyœwietliæ "has³o niepoprawne").
void task6()
{
    string password;

    cout << "input password \n";
    cin >> password;

    if (password == "grzegorz23")
        cout << "password correct \n";
    else
        cout << "password incorrect \n";
}

//Program sprawdzaj¹cy czy podana data jest poprawna (np. sprawdzaj¹c, czy dzieñ jest z zakresu od 1 do 31, miesi¹c od 1 do 12 itd.)
void task7()
{
    int day, month, year;

    cout << "input day of the month \n";
    cin >> day;
    cout << "input month \n";
    cin >> month;
    cout << "input year \n";
    cin >> year;

    if (month == 2)
    {
        if (day > 0 && day < 29)
        {

            if (year >= 0)
            {
                cout << "the date is correct \n";
            }
            else
            {
                cout << "the date is incorrect \n";
            }
        }
        else
        {
            cout << "the date is incorrect \n";
        }
    }
    else if (month > 0 && month < 13)
    {
        if (month == 1, 3, 5, 7, 8, 10, 12);
    }
}

void test()
{
    int month;
    cin >> month;
    if (month == 12)
    {
        cout << "the month has 31 days";
    }
    else
    cout << "the date is incorrect \n";
}

int main()
{
    setlocale(LC_CTYPE, "polish");

    //task1();
    //task2();
    //task3();
    //task4();
    //task5();
    //task6();
    //task7();
    test();
}