using Geometry;

namespace Architectural
{
    public class Window
    {
        private double area;
        private Point fromPoint;
        private Point toPoint;

        public Window(double area)
        {
            this.area = area;
            var inclination = new Physics.Sun().GetInclinationAngle();            
        }

        public double GetArea(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10)
        {
            return 1.1;
        }
    }
}
