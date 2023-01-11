using System;
using NUnit.Framework;

namespace AndroidTestProject1
{
    [TestFixture]
    public class TestsSample
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void Tear()
        {
        }

        [Test]
        public void Pass()
        {
            Assert.True(true);
        }

        [Test]
        public void Fail()
        {
            Assert.False(true);
        }

        [Test]
        [Ignore("Ignore this test")]
        public void Ignore()
        {
            Assert.True(false);
        }

        [Test]
        public void Inconclusive()
        {
            Assert.Inconclusive("Inconclusive");
        }
    }
}