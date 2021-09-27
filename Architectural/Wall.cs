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

        /// <summary>
        /// Implement wall functionality
        /// </summary>
        public Wall()
        {
            var sun = new Physics.Sun();
            radiation = sun.GetInclinationAngle();
            windows = new List<Window>();
            doors = new List<Door>();
        }
        public double GetArea(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10)
        {
            return 1.1;
        }
    }
}
