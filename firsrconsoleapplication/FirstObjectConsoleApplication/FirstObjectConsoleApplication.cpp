
#include <iostream>

using namespace std;

class Point
{
private:
	int x;
	int y;
	int z;

public:
	Point()
	{
		x = 3;
		y = 7;
		z = 10;
	}

	Point(int xx)
	{
		x = xx;
		y = 7;
		z = 10;
	}

	Point(int xx, int yy, int zz)
	{
		x = xx;
		y = yy;
		z = zz;
	}

	~Point()
	{
		cout << "Teraz dzia�a destruktor\n";
	}

	Point(Point &p)
	{
		x = p.x;
		y = p.y;
		z = p.z;
	}

	void SetX(int value)
	{
		//x = abs(value);
		if (value >= 0)
			x = value;
		else
		{
			//reakcja na b��d
		}
	}

	int GetX()
	{
		//if (uprawnienia)

		return x;
	}

	double DistanceFromCenter()
	{
		double distance;
		distance = sqrt(x * x + y * y + z * z);
		return distance;
	}
};

/*
Zdefiniuj klase opisuj�c� prostok�t. Mo�liwo�ci klasy:
* konstruktory
* metoda kt�ra zw�rci obw�d prostok�ta
* metoda kt�ra pole prostok�ta
* metod� kt�ra poka�e informacje o prostok�cie.

Napisz program kt�ry zaprezentuje mo�liwo�ci obiektu na podstawie tej klasy.
*/

class Rectangle
{
private:
	int width;
	int height;

public:
	Rectangle()
	{
		height = 0;
		width = 0;
	}

	Rectangle(int setWidth, int setHeight)
	{
		width = setWidth;
		height = setHeight;
	}

	~Rectangle()
	{
		cout << "dekonstruktuje...\n";
	}

	int getCircumference()
	{
		int circ = width * 2 + height * 2;
		return circ;
	}

	int getArea()
	{
		int area = width * height;
		return area;
	}

	void getInfo()
	{
		cout << "Rectangle: \n\twidth: " << width << "\n\theight: " << height << "\n\tarea: " << getArea() << "\n\tcircumference: " << getCircumference() << "\n";
	}
};

/*
ZADANIE
Zdefiniuj klase opisuj�ce konto bankowe. Mo�liwo�ci klasy:
* konstruktory
* metoda kt�ra dokona wp�aty na konto
* metoda kt�ra wyp�aty z konta
* metoda kt�ra wykona przelew na inne konto
* metod� kt�ra poka�e informacje o koncie.

Napisz program kt�ry zaprezentuje mo�liwo�ci obiektu na podstawie tej klasy.
*/

class BankAcc
{
private:
	double money;

public:
	BankAcc()
	{
		money = 0;
	}

	~BankAcc()
	{
		cout << "closing your bank account... thank you for using our services\n";
	}

	void DepositOrPayment(double change)
	{
		if (change >= 0)
			money += change;
		else if (change < 0 && change < money)
			money -= change;
	}

	double TransferMoney(double amountOfMoney)
	{
		if (amountOfMoney <= money && amountOfMoney > 0)
		{
			money -= amountOfMoney;
			return amountOfMoney;
		}
		else if (amountOfMoney > money || amountOfMoney < 0)
		{
			return 0;
		}
	}

	void AccountInfo()
	{
		cout << "money in account: " << money;
	}

};

int main()
{
	setlocale(LC_ALL, "");

	BankAcc firstbank, secondbank;

	cout << "pierwsze konto: ";
	firstbank.AccountInfo();
	cout << "\ndrugie konto: ";
	secondbank.AccountInfo();

	cout << "\n\n";

	firstbank.DepositOrPayment(10);
	secondbank.DepositOrPayment(100);

	cout << "pierwsze konto: ";
	firstbank.AccountInfo();
	cout << "\ndrugie konto: ";
	secondbank.AccountInfo();

	cout << "\n\n";

	firstbank.DepositOrPayment(secondbank.TransferMoney(110));

	cout << "pierwsze konto: ";
	firstbank.AccountInfo();
	cout << "\ndrugie konto: ";
	secondbank.AccountInfo();

	cout << "\n";
}