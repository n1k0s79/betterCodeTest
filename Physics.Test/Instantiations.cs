using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Physics.Test
{
    [TestClass]
    public class Instantiations
    {
        [TestMethod]
        public void Instantiate()
        {
            var sun = new Sun();
            Assert.IsNotNull(sun);
        }
    }
}
