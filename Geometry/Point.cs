using System;
using System.Diagnostics;

namespace Geometry
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double GetDistance(Point other)
        {
            Debug.Assert(other != null);
            return 0;
        }
    }
}
