using Geometry;
using System.Collections.Generic;

namespace Architectural
{
    public class Wall
    {
        private double radiation;

        private IEnumerable<Window> windows;
        private IEnumerable<Door> doors;
        private Point fromPoint;
        private Point toPoint;

        public Wall()
        {
            var sun = new Physics.Sun();
            radiation = sun.GetInclinationAngle();
            windows = new List<Window>();
            doors = new List<Door>();
        }
    }
}
