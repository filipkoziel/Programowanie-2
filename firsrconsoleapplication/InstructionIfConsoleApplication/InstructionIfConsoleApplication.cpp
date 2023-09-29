#include <iostream>

using namespace std;

//Napisz funkje, która podieli dwie liczby
void task1()
{
    double frstNum, scndNum;

    cout << "podaj pierwsz¹ liczbe \n";
    cin >> frstNum;
    cout << "podaj drug¹ liczbe \n";
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
 