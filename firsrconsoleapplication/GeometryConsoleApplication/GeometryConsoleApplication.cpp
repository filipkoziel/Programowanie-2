#include <iostream>

using namespace std;

// napisz klasy, które bêd¹ opisywaæ kwadrat, prostok¹t, trapez

class Parallelogram
{
protected:
	double sideA, sideB, sideC, sideD, height;

public:

};

class Square:public Parallelogram
{
protected:

public:
	Square(double side)
	{
		sideA = sideB = sideC = sideD = side;
	}
};

class Recangle:public Parallelogram
{
protected:

public:
	Recangle(double firstSide, double secondSide)
	{
		sideA = sideC = firstSide;
		sideB + sideD = secondSide;
	}

};

class Trapeze:public Parallelogram
{
protected:

public:
	Trapeze(double firstSide, double secondSide, double thirdSide, double fourthSide, double h)
	{
		sideA = firstSide;
		sideB = secondSide;
		sideC = thirdSide;
		sideD = fourthSide;
		height = h;
	}
};

int main()
{
	Recangle r(10,5);
	
	Square s(6);

	Trapeze t(10, 6, 4, 5, 3);
}

