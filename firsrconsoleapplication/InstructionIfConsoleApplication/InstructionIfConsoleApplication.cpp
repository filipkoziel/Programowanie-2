#include <iostream>
#include <math.h>

using namespace std;


/*
11. 
12. 
13. Napisz program, który na podstawie wspó³czynników równania kwadratowego(a, b, c) sprawdzi, czy to równanie ma rozwi¹zania rzeczywiste, i jeœli tak, to je obliczy.
*/



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
    double bokA;
    double bokB;
    double bokC;

    cout << "input lengh of side a \n";
    cin >> bokA;
    cout << "input lengh of side b \n";
    cin >> bokB;
    cout << "input lengh of side c \n";
    cin >> bokC;

    if (bokA + bokB > bokC && bokA + bokC > bokB && bokB + bokC > bokA)
    {
        cout << "triangle with sides of lengh: " << bokA << ", " << bokB << ", " << bokC << "\nis correct\n";
    }
    else
    {
        cout << "A triangle with sides of lengh: " << bokA << ", " << bokB << ", " << bokC << "\ndoes not exist \n";
    }
}

// Napisz program, który bêdzie dzia³aæ jako prosty kalkulator matematyczny, umo¿liwiaj¹c u¿ytkownikowi wybór operacji(dodawanie, odejmowanie, mno¿enie, dzielenie) i wprowadzanie liczb do obliczeñ.
void task11()
{
    int numOperacii;

    cout << "Kalkulator: \n1.Dodawanie \n2.Odejmowanie \n3.Mno¿enie \n4.Dzielenie \nWypisz numer operacij któr¹ chcesz wykonaæ\n";

    cin >> numOperacii;

    if (numOperacii == 1)
    {
        int num1, num2;

        cout << "wprowadŸ dwa numery do dodania\n\n";

        cout << "numer 1:\n";
        cin >> num1;
        cout << "numer 2:\n";
        cin >> num2;

        cout << "suma tych liczb to: " << num1 + num2 << "\n";
    }
    else if (numOperacii == 2)
    {
        int num1, num2;

        cout << "wprowadŸ dwa numery do odjencia\n\n";

        cout << "numer 1:\n";
        cin >> num1;
        cout << "numer 2:\n";
        cin >> num2;

        cout << "ró¿nica tych liczb to: " << num1 - num2 << "\n";
    }
    else if (numOperacii == 3)
    {
        int num1, num2;

        cout << "wprowadŸ dwa numery do mno¿enia\n\n";

        cout << "numer 1:\n";
        cin >> num1;
        cout << "numer 2:\n";
        cin >> num2;

        cout << "iloczyn tych liczb to: " << num1 * num2 << "\n";
    }
    else if (numOperacii == 4)
    {
        int num1, num2;

        cout << "wprowadŸ dwa numery do dzielenia\n\n";

        cout << "numer 1:\n";
        cin >> num1;
        cout << "numer 2:\n";
        cin >> num2;

        cout << "iloraz tych liczb to: " << num1 / num2 << "\n";
    }
    else
    {
        cout << "nie ma takiej opcij!!\n";
    }
}

//Napisz program, który wczyta numer miesi¹ca i wyœwietli jego s³owny odpowiednik.
void task12()
{
    int numerMiesi¹ca;

    cout << "Podaj numer miesi¹ca\n";
    cin >> numerMiesi¹ca;

    switch (numerMiesi¹ca)
    {
    case 1:
        cout << "styczeñ\n";
        break;
    case 2:
        cout << "luty\n";
        break;
    case 3:
        cout << "marzec\n";
        break;
    case 4:
        cout << "kwiecieñ\n";
        break;
    case 5:
        cout << "maj\n";
        break;
    case 6:
        cout << "czerwiec\n";
        break;
    case 7:
        cout << "lipiec\n";
        break;
    case 8:
        cout << "sierpieñ\n";
        break;
    case 9:
        cout << "wrzesieñ\n";
        break;
    case 10:
        cout << "paŸdziernik\n";
        break;
    case 11:
        cout << "listopad\n";
        break;
    case 12:
        cout << "grudzieñ\n";
        break;
    default:
        cout << "nie ma takiego miesi¹ca\n";
    }
}

// Napisz program, który na podstawie wspó³czynników równania kwadratowego(a, b, c) sprawdzi, czy to równanie ma rozwi¹zania rzeczywiste, i jeœli tak, to je obliczy.
void task13()
{
    double a, b, c, x;

    cout << "wprowadŸ liczbe a do równania kwadratowego, a nie mo¿e byæ równe 0\n";
    cin >> a;
    cout << "wprowadŸ liczbe b do równania kwadratowego\n";
    cin >> b;
    cout << "wprowadŸ liczbe c do równania kwadratowego\n";
    cin >> c;

    // a * pow(x, 2) + b * x + c

    double delta = pow(b, 2) - 4 * a * c;


    if (delta == 0)
    {
        double result = (b * (-1)) / (2 * a);

        cout << "Takie równanie kwadratowe ma jedno rozwi¹zanie:\n";
        cout << result << "\n";
    }
    else if (delta > 0)
    {
        double result1, result2;
        result1 = (((-1) * b) - sqrt(delta)) / (2 * a);
        result2 = (((-1) * b) + sqrt(delta)) / (2 * a);

        cout << "Takie równanie kwadratowe ma dwa rozwi¹zania.\n";
        cout << result1 << "\n";
        cout << result2 << "\n";
    }
    else (delta < 0 || a == 0);
    {
        cout << "Takie równanie kwadratowe nie ma rozwi¹zañ.\n";
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
    //task11();
    task13();
    //test();
}