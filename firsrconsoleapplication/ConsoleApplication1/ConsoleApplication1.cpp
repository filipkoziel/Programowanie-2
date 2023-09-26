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
    cout << "input first number \n";
    cin >> fstNumber;
    cout << "input second number \n";
    cin >> sndNumber;

    double average = (fstNumber + sndNumber) / 2;

    cout << "arithmetic average: " << average << "\n";
}

//2. Program obliczaj�cy pole prostok�ta.
void task2()
{
    double a, b;
    cout << "input rectangle side a \n";
    cin >> a;
    cout << "input rectangle side b \n";
    cin >> b;

    double volume = a * b;

    cout << "volume of ractangle:" << volume << "\n";
}

//3. Program obliczaj�cy obj�to�� sto�ka.
void task3()
{
    double radius, height;

    cout << "input cone radius \n";
    cin >> radius;
    cout << "input cone height \n";
    cin >> height;

    double coneVolume = (1.0 / 3.0) * 3.14 * pow(radius, 2.0) * height;

    cout << "cone volume: " << coneVolume << "\n";
}

//4. Program obliczaj�cy pole ko�a.
void task4()
{
    double radius;

    cout << "input circle radius \n";
    cin >> radius;

    double circleVolume = 3.14 * pow(radius, 2.0);

    cout << "circle volume: " << circleVolume << "\n";
}

//5. Program obliczaj�cy warto�� wyra�enia a^2 + b^2
void task5()
{
    double a, b;

    cout << "input a \n";
    cin >> a;
    cout << "input b \n";
    cin >> b;

    double value = pow(a, 2.0) + pow(b, 2.0);

    cout << "value of a^2 + b^2: " << value;
}

//6. Program obliczaj�cy pole tr�jk�ta o podstawie b i wysoko�ci h
void task6()
{
    double base, height;

    cout << "input base \n";
    cin >> base;
    cout << "input height \n";
    cin >> height;

    double Volume = (base * height) / 2;

    cout << "the volume of a triangle with a base of " << base << " and a height of " << height << " is: " << Volume << "\n";
}

//7. Program obliczaj�cy obj�to�� kuli o promieniu r
void task7()
{
    double radius;

    cout << "input radius \n";
    cin >> radius;

    double volume = (4.0 / 3.0) * M_PI * pow(radius, 3.0);

    cout << "The volume of a sphere with the radius of " << radius << " is: " << volume << "\n";
}

// 8. Program obliczaj�cy pole trapezu o podstawach a i b oraz wysoko�ci h
void task8()
{
    double aBase, bBase, height;

    cout << "input base a \n";
    cin >> aBase;    
    cout << "input base b \n";
    cin >> bBase;    
    cout << "input height \n";
    cin >> height;

    double volume = ((aBase + bBase) * height) / 2;

    cout << "The volume of a trapeze with bases of " << aBase << " and " << bBase << " is: " << volume << "\n";
}

// 9. Program obliczaj�cy �redni� wa�on� trzech liczb z podanymi odpowiednimi wagami w1, w2 i w3.
void task9()
{
    double aNumber, bNumber, cNumber, aWeight, bWeight, cWeight;

    aNumber = 8.0;
    bNumber = 2.0;
    cNumber = 4.0;

    cout << "input weight of first number with value 8 \n";
    cin >> aWeight;
    cout << "input weight of second number with value 2 \n";
    cin >> bWeight;
    cout << "input weight of third number with value 4 \n";
    cin >> cWeight;

    double weightedAverage = ((aNumber * aWeight) + (bNumber * bWeight) + (cNumber * cWeight)) / 3;

    cout << "The weighted average of those numbers with those weights is: " << weightedAverage << "\n";
}

int main()
{
    //test();
    task1();
    task2();
    task3();
    task4();
    task5();
    task6();
    task7();
    task8();
    task9();
}