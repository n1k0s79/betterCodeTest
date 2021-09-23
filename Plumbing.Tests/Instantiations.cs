using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Plumbing.Tests
{
    [TestClass]
    public class Instantiations
    {
        [TestMethod]
        public void Instantiate()
        {
            var pipe = new Pipe();
            Assert.IsNotNull(pipe);
        }
    }
}
