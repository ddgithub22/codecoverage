using CodeCoverage;
using NUnit.Framework;

namespace CodeCoverageTest
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void AddTest()
        {
            Assert.AreEqual(2, new Program().Add(1, 1));
        }
    }
}
