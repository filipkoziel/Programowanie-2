#include <iostream>

using namespace std;

//Napisz funkje, kt�ra podieli dwie liczby
void task1()
{
    double frstNum, scndNum;

    cout << "podaj pierwsz� liczbe \n";
    cin >> frstNum;
    cout << "podaj drug� liczbe \n";
    cin >> scndNum;

    if (scndNum != 0)
    {
        double quotient = frstNum / scndNum;

        cout << "wynik dielenia: " << quotient << "\n";
    }
    else
    {
        cout << "dzielenie przez zero!!!!!!! \n";
    }
}

int main()
{
    setlocale(LC_CTYPE, "polish");
    task1();
}
 