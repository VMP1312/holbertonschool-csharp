using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class OperationsTests
    {
    
        [Test]
        public void Positives()
        {
            int a = 2;
            int b = ;
            Assert.AreEqual(MyMath.Operations.Add(a, b), 3);
        }

        [Test]
        public void Negatives()
        {
            Assert.AreEqual(MyMath.Operations.Add(-2, -1), -3);
        }

        [TestCase(1, 2)]
        [TestCase(-2, -1)]
        [TestCase(0, 0)]
        [TestCase(-2, 0)]
        [TestCase(-2, 1)]

        [Test]
        public void Test_adding_two_integers(int a, int b)
        {
            Assert.AreEqual(MyMath.Operations.Add(a, b), a + b);
        }
    }
}
