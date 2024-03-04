
#include <iostream>

using namespace std;

/*
Zdefiniuj klase opisuj�c� prostok�t. Mo�liwo�ci klasy:
* konstruktory
* metoda kt�ra zw�rci obw�d prostok�ta
* metoda kt�ra pole prostok�ta
* metod� kt�ra poka�e informacje o prostok�cie.

Napisz program kt�ry zaprezentuje mo�liwo�ci obiektu na podstawie tej klasy.
*/

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
		cout << "koniec :p\n";
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

int main()
{
	Rectangle firstRectangle(12, 6);

	firstRectangle.getInfo();
}