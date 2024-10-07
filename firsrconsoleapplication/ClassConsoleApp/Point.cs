using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConsoleApp
{
    class Point
    {
        public int x, y;

        public double calculateDistanceFromCenter()
        {
            double d = 0;
            d = Math.Sqrt(x * x + y * y);
            return d;
        }
    }
}
