using System.Collections.Generic;
using NUnit.Framework;

namespace KataFindUppercase
{
    [TestFixture]
    public class KataFindUppercaseTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(new List<int>(){0}, KataFindUppercase.execute("Hello"));
        }
    }
}