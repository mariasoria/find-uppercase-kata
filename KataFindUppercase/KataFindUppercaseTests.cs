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
            Assert.AreEqual(new List<int>() { 0 }, KataFindUppercase.Execute("Hello", new List<int>(),0));
            Assert.AreEqual(new List<int>() { 0, 6 }, KataFindUppercase.Execute("Hello World", new List<int>(),0));
            Assert.AreEqual(new List<int>() { 0, 17, 23 }, KataFindUppercase.Execute("Hello my friend, Hello World", new List<int>(),0));
            Assert.AreEqual(new List<int>() { 0, 3, 4, 6 }, KataFindUppercase.Execute("CodEWaRs", new List<int>(),0));
        }
    }
}