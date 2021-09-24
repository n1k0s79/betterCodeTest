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
    }
}
