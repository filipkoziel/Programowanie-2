#include <iostream>

using namespace std;

class Quadrangle
{
protected:
	double sideA, sideB, sideC, sideD, height;

public:
	Quadrangle(double firstSide, double secondSide, double thirdSide, double fourthSide, double h)
	{
		sideA = firstSide;
		sideB = secondSide;
		sideC = thirdSide;
		sideD = fourthSide;
		height = h;
	}

	double GetPerimeter()
	{
		return sideA + sideB + sideC + sideD;
	}
};

class Rectangle:public Quadrangle
{
protected:

public:
	Rectangle(double firstSide, double secondSide) : Quadrangle(firstSide, secondSide, firstSide, secondSide, secondSide)
	{
		//sideA = sideC = firstSide;
		//sideB + sideD = secondSide;
	}

	double GetArea()
	{
		return sideA * sideB;
	}

};

class Square :public Rectangle
{
protected:

public:
	Square(double side) : Rectangle(side, side)
	{
		//sideA = sideB = sideC = sideD = side;
	}

	// GetArea inherited from Rectangle
};

class Trapeze:public Quadrangle
{
protected:

public:
	Trapeze(double firstSide, double secondSide, double thirdSide, double fourthSide, double h) : Quadrangle(firstSide, secondSide, thirdSide, fourthSide, h)
	{
		//sideA = firstSide;
		//sideB = secondSide;
		//sideC = thirdSide;
		//sideD = fourthSide;
		//height = h;
	}

	double GetArea()
	{
		return ((sideA + sideC) / 2) * height;
	}
};

int main()
{
	Quadrangle q(3, 2, 5, 4, 2);

	Rectangle r(10, 5);
	std::cout << r.GetArea() << "\n";
	std::cout << r.GetPerimeter() << "\n";

	Square s(6);
	std::cout << s.GetArea() << "\n";
	std::cout << s.GetPerimeter() << "\n";

	Trapeze t(10, 6, 4, 5, 3);
	std::cout << t.GetArea() << "\n";
	std::cout << t.GetPerimeter() << "\n";
}

