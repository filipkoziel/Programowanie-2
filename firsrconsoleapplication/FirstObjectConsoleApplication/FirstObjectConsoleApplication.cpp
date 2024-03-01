
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

	void SetX(int value)
	{
		if (x >= 0)
		{
			x = value;
		}
		else
		{
			//reakcja na b³¹d
		}
	}
	int GetX()
	{
		return x;
	}

	double DistanceFromZero()
	{
		double distance;

		distance = sqrt(x * x + y * y + z * z);
		return distance;
	}


};

int main()
{
	Point firstpoint;
	cout << "odleg³oœæ " << firstpoint.DistanceFromZero() << "\n";

	Point secondpoint;
	cout << "odleg³oœæ " << secondpoint.DistanceFromZero() << "\n";
}
 