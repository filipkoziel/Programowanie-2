#include <iostream>

using namespace std;

/*

* Dla poni�szych klas u�� drzewko dziedziczenia.
- Tiger (Tygrys), Dog (Pies), Fish (Ryba), Eagle (Orze�), Mammal (Ssak), Lion (Lew), Sparrow (Wr�bel), Reptile (Gad), Trout (Pstr�g), Cat (Kot), Salmon (�oso�), Animal (Zwierz�), Snake (W��), Bird (Ptak), Turtle (��w)
- SUV (SUV), Pickup Truck (Pick-up), Truck (Ci�ar�wka), Car (Samoch�d), Sedan (Sedan), Motorcycle (Motocykl), Vehicle (Pojazd), Semi-Truck (Ci�gnik siod�owy)
- Smartphone (Smartfon), Android Phone (Telefon z systemem Android), Electronic Device (Urz�dzenie elektroniczne), LED TV (Telewizor LED), Laptop (Laptop), iPhone (iPhone), Television (Telewizor), Smart TV (Telewizor Smart)
*/

class Animal
{

};

    class Mammal :public Animal
    {

    };

        class Tiger :public Mammal
        {

        };

        class Dog :public Mammal
        {

        };

        class Lion :public Mammal
        {

        };

        class Cat :public Mammal
        {

        };

    class Reptile :public Animal
    {

    };

        class Snake :Reptile
        {

        };

        class Turtle :Reptile
        {

        };

    class Fish :public Animal
    {

    };

        class Trout :public Fish
        {

        };

        class Salmon :public Fish
        {

        };

    class Bird :public Animal
    {

    };

        class Eagle :public Bird
        {

        };

        class Sparrow :public Bird
        {

        };


class Vechicle
{

};

    class Car :public Vechicle
    {

    };

        class SUV :public Car
        {

        };

        class Pickup_Truck :public Car
        {

        };

    class Truck :public Vechicle
    {

    };

        class Semi_Truck :public Truck
        {

        };

    class Motorcycle :public Vechicle
    {

    };



class Electronic_Device
{

};

    class Smartphone :public Electronic_Device
    {

    };

        class Android_Phone :public Smartphone
        {

        };

        class iPhone :public Smartphone
        {

        };

    class Television :public Electronic_Device
    {

    };

        class LED_TV :public Television
        {

        };

        class Smart_TV :public Television
        {

        };

    class Laptop :public Electronic_Device
    {

    };

int main()
{
    std::cout << "Hello World!\n";
}
