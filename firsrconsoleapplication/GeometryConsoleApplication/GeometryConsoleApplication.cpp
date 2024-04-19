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

}

