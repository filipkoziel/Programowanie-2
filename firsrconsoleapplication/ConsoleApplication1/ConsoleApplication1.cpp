#define _USE_MATH_DEFINES
#include <iostream>
#include <math.h>

using namespace std;

void test()
{
    cout << "Hello World!\n";
    cout << -59.5 << 'x' << "ghfghjfghj" << true << false << '\n';

    int number;
    number = 5;

    int secondNumber;
    secondNumber = number + 2;
    /*
    Priorytet operator�w:

    (, )
    +, - (unarne)
    *, /, %
    +, -
    =

    */
    cout << "Komuinikat \n";
    cin >> secondNumber >> number;
}

/*
Podstawy programowania:

1.Program obliczaj�cy �redni� arytmetyczn� dw�ch liczb.
2. Program obliczaj�cy pole prostok�ta.
3. Program obliczaj�cy obj�to�� sto�ka.
4. Program obliczaj�cy pole ko�a.
5. Program obliczaj�cy warto�� wyra�enia a^2 + b^2
6. Program obliczaj�cy pole tr�jk�ta o podstawie b i wysoko�ci h
7. Program obliczaj�cy obj�to�� kuli o promieniu r
8. Program obliczaj�cy pole trapezu o podstawach a i b oraz wysoko�ci h
9. Program obliczaj�cy �redni� wa�on� trzech liczb z podanymi odpowiednimi wagami w1, w2 i w3.
*/

//1. Program obliczaj�cy �redni� arytmetyczn� dw�ch liczb.
void task1()
{
    double fstNumber, sndNumber;
    cout << "imput first number \n";
    cin >> fstNumber;
    cout << "imput second number \n";
    cin >> sndNumber;
    cout << "arithmetic average: " << (fstNumber + sndNumber) / 2;
}

//2. Program obliczaj�cy pole prostok�ta.
void task2()
{
    double a, b;
    cout << "imput rectangle side a \n";
    cin >> a;
    cout << "imput rectangle side b \n";
    cin >> b;
    cout << a * b;
}

//3. Program obliczaj�cy obj�to�� sto�ka.
void task3()
{
    double radius, height;

    cout << "imput cone radius \n";
    cin >> radius;
    cout << "imput cone height \n";
    cin >> height;

    double coneVolume = (1.0 / 3.0) * 3.14 * pow(radius, 2.0) * height;

    cout << "cone volume = \n" << coneVolume;
}

//4. Program obliczaj�cy pole ko�a.
void task4()
{
    double radius;

    cout << "imput circle radius \n";
    cin >> radius;

    double circleVolume = 3.14 * pow(radius, 2.0);

    cout << "circle volume: " << circleVolume << "\n";
}

//5. Program obliczaj�cy warto�� wyra�enia a^2 + b^2
void task5()
{
    double a, b;

    cout << "imput a \n";
    cin >> a;
    cout << "imput b \n";
    cin >> b;

    double value = pow(a, 2.0) + pow(b, 2.0);

    cout << "value of a^2 + b^2: " << value;
}

int main()
{
    //test();
    //task1();
    //task2();
    //task3();
    //task4();
    task5();
}