using System;
using NUnit.Framework; 

namespace UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void TestMethod()
        {
            Assert.That(2, Is.EqualTo(2));
        }
    }
}
