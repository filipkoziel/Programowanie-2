#include <iostream>

using namespace std;


//Napisz funkcjê, która podzieli dwie liczby.
void task0()
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
void task1()
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
void task2()
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
void task3()
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
void task4()
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
void task5()
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
void task6()
{
    int day, month, year;

    cout << "input day of the month \n";
    cin >> day;
    cout << "input month \n";
    cin >> month;
    cout << "input year \n";
    cin >> year;

    if (year > 0)
    {
        if (month > 0 && month <= 12)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day > 0 && day <= 31)
                {
                    cout << "the date is correct \n";
                }
                else
                {
                    cout << "the day is incorrect \n";
                }
            }

            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day > 0 && day <= 30)
                {
                    cout << "the date is correct \n";
                }
            }
            else if (month == 2)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    if (day > 0 && day <= 29)
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
                    if (day > 0 && day <= 28)
                    {
                        cout << "the date is correct \n";
                    }
                    else
                    {
                        cout << "the date is incorrect \n";
                    }
                }
            }
            else
            {
                cout << "the month is incorrect \n";
            }
        }
        else
        {
            cout << "the month is incorrect \n";
        }
    }
    else
    {
        cout << "the year is less then 0 \n";
    }
}

// Program wyœwietlaj¹cy odpowiedni komunikat w zale¿noœci od podanej temperatury (np. "ciep³o" dla temperatury powy¿ej 20 stopni Celsjusza, "ch³odno" dla temperatury poni¿ej 10 stopni Celsjusza itd.)
void task7()
{
    double temp;

    cout << "podaj temperature \n";
    cin >> temp;

    if (temp >= 27)
        cout << "gor¹co";
    else if (temp >= 20)
        cout << "ciep³o";
    else if (temp >= 10)
        cout << "umiarkowanie";
    else if (temp >= 0)
        cout << "zimno";
    else if (temp >= -10)
        cout << "mroŸno";
    else
        cout << "za zimno";
}

//Program sprawdzj¹cy czy podana liczba jest z przedia³u < 1; 15)
void task8()
{
    double number;

    cout << "input number \n";
    cin >> number;

    if (number >= 0 && number < 15)
    {
        cout << "the number is within <1;15) \n";
    }
    else
    {
        cout << "the number isn't within <1;15) \n";
    }
}

//Program sprawdzaj¹cy czy osoba jest pe³noletnia.
void task9()
{
    int yearOfBirth;

    cout << "when were you born? \n";
    cin >> yearOfBirth;
    
    if (yearOfBirth <= 2005)
    {
        cout << "You are an adult \n";
    }
    else
    {
        cout << "You are not an adult \n";
    }
}

//Program, który sprawdzi czy z podanych d³ugoœci boków mo¿na zrobiæ trójk¹t.
void task10()
{
    double a;
    double b;
    double c;

    cout << "input lengh of side a \n";
    cin >> a;
    cout << "input lengh of side b \n";
    cin >> b;
    cout << "input lengh of side c \n";
    cin >> c;

    if (a + b > c && a + c > b && b + c > a)
    {
        cout << "triangle with sides of lengh: " << a << ", " << b << ", " << c << "\nis correct\n";
    }
    else
    {
        cout << "A triangle with sides of lengh: " << a << ", " << b << ", " << c << "\ndoes not exist \n";
    }
}

void test()
{

}

int main()
{
    setlocale(LC_CTYPE, "polish");

    //task0
    //task1();
    //task2();
    //task3();
    //task4();
    //task5();
    //task6();
    //task7();
    //task8();
    //task9();
    //task10();
    //test();
}