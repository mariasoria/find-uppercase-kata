using NUnit.Framework;

namespace KataFindUppercase
{
    [TestFixture]
    public class KataFindUppercaseTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(KataFindUppercase.execute("Hello"), "Hello");
        }
    }
}