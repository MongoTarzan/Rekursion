using NUnit.Framework;


namespace MyRecursionTest
{
    public class RecursionTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFakultaetOf4()
        {
            int result = Rekursion.fakultaet(4);
            Assert.AreEqual(result, 24);
        }

        [Test]
        public void TestFakultaetOf5()
        {
            int result = Rekursion.fakultaet(5);
            Assert.AreEqual(result, 120);
        }

        [Test]
        public void TestFibbonacciSeqNumber5()
        {
            int result = Rekursion.fibonacci(5);
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void TestFibbonacciSeqNumber6()
        {
            int result = Rekursion.fibonacci(6);
            Assert.AreEqual(result, 8);
        }
    }
}