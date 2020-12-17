using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void When_0()
        {
            int[,] firstMatrix = new int[2, 2] {{4, 2}, {2, 4}};

            int[,] newMatrix = Matrix.Divide(firstMatrix, 0);
            Assert.AreEqual(null, newMatrix);
        }

        [Test]
        public void When_Null()
        {
            int[,] firstMatrix = null;

            int[,] newMatrix = Matrix.Divide(firstMatrix, 5);
            Assert.AreEqual(null, newMatrix);
        }
        
        [Test]
        public void When_Normal()
        {
            int[,] firstMatrix = new int[2, 2] {{4, 2}, {2, 4}};

            int[,] newMatrix = Matrix.Divide(firstMatrix, 2);
            Assert.AreEqual(new int[2, 2] {{2, 1}, {2, 1}}, newMatrix);
        }
    }
}
