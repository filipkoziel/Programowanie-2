
#include <iostream>

using namespace std;

void task1()
{
    int number;

    do
    {
        cout << "wprowad� liczbe\n";
        cin >> number; 
    } while (number != 0);
}

void task2()
{
    int a, b;
    cout << "wprowad� pierwsz� liczbe\n";
    cin >> a;
    cout << "wprowad� drug� liczbe\n";
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
    cout << "wprowad� numer\n";
    cin >> number;


    for (int i = 0; i > number)
    {
        cout << i + 1;
        count++
    }
}


int main()
{
    //task1();
    //task2();
    task3();
}

