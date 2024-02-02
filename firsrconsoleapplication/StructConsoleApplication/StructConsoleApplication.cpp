
#include <iostream>

using namespace std;

struct point
{
	int x;
	int y;
	int z;
};

double DistanceFromZero(int x, int y, int z)
{
	double distance;
	distance = sqrt(x * x + y * y);
	return distance;
}

double DistanceFromZero(point p)
{
	double distance;

	distance = sqrt(p.x * p.x + p.y * p.y + p.z * p.z);
	return distance;
}

int main()
{
	setlocale(LC_CTYPE, "polish");

	// podaje koordynaty na tablicy i sprawdza odleg³oœæ od (0,0)

	int x, y, z;

	cout << "podaj x\n";
	cin >> x;
	cout << "podaj y\n";
	cin >> y;
	cout << "podaj z\n";
	cin >> z;

	cout << "odleg³oœæ " << DistanceFromZero(x, y, z) << "\n";

	int x1, y1;
	int x2, y2;

	int xx[50], yy[50], zz[50];
	xx[3] = 3;
	yy[3] = 7;
	zz[3] = 77;

	point firstpoint;
	firstpoint.x = 3;
	firstpoint.y = 8;
	firstpoint.z = 5;
	cout << "odleg³oœæ " << DistanceFromZero(firstpoint.x, firstpoint.y, firstpoint.z) << "\n";
	cout << "odleg³oœæ " << DistanceFromZero(firstpoint) << "\n";

}
