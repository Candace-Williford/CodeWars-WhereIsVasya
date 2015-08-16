using NUnit.Framework;
using System;
using WhereIsVasya_CodeWars;

namespace WhereIsVasya_CodeWars.Tests
{
    [TestFixture]
    public class LineTests
    { 
        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, Line.WhereIsHe(3, 1, 1));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(3, Line.WhereIsHe(5, 2, 3));
        }
    }
}