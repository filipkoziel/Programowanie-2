// struct console app


Point firstpoint = new Point();
firstpoint.x = 5;
firstpoint.y = 10;

Point secondpoint = new Point();
secondpoint.x = 6;
secondpoint.y = 99;

double distance;

distance = calculateDistanceFromCenter(ref firstpoint);

Console.WriteLine($"distance of first point from (0, 0) equals {distance}");

distance = calculateDistanceFromCenter(ref secondpoint);

Console.WriteLine($"distance of first point from (0, 0) equals {distance}");

double calculateDistanceFromCenter(ref Point p)
{
    double d = 0;
    d = Math.Sqrt(p.x * p.x + p.y * p.y);
    return d;
}


