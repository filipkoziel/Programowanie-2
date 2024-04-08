#include <iostream>

using namespace std;

// napisz klasy, które bêd¹ opisywaæ kwadrat, prostok¹t, trapez

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

class Recangle:public Quadrangle
{
protected:

public:
	Recangle(double firstSide, double secondSide) : Quadrangle(firstSide, secondSide, firstSide, secondSide, secondSide)
	{
		//sideA = sideC = firstSide;
		//sideB + sideD = secondSide;
	}

	double GetArea()
	{
		return sideA * sideB;
	}

};

class Square :public Recangle
{
protected:

public:
	Square(double side) : Recangle(side, side)
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

	Recangle r(10,5);
	cout << r.GetArea() << "\n";
	
	Square s(6);
	cout << s.GetArea() << "\n";

	Trapeze t(10, 6, 4, 5, 3);
	cout << t.GetArea() << "\n";
}

