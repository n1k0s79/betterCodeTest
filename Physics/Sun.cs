using System;

namespace Physics
{
    public class Sun
    {
        public double GetInclinationAngle()
        {
            var p1 = new Geometry.Point(1, 2);
            var p2 = new Geometry.Point(3, 4);
            var dist = p1.GetDistance(p2);
            return dist;
        }
    }
}
