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
    }
}
