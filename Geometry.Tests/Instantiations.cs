using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometry.Tests
{
    [TestClass]
    public class Instantiations
    {
        [TestMethod]
        public void Instantiate()
        {
            var p = new Point(1, 2);
            Assert.AreEqual(1, p.X);
            Assert.AreEqual(2, p.Y);
        }

        [TestMethod]
        public void Distance()
        {
            var p1 = new Point(1, 2);
            Point p2 = null;
            var dist = p1.GetDistance(p2);
        }
    }
}
