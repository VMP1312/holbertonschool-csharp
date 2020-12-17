using NUnit.Framework;

namespace MyMath.Tests
{
    ///<summary> Tests for "Operations"</summary>
    
    public class OperationsTests
    {
        
        /// <sumary> Test the "Add" method.</sumary>
        [Test]

        [TestCase(8, 13)]
        [TestCase(-8, 13)]
        [TestCase(8, -13)]
        [TestCase(-8, -13)]
        [TestCase(0, 5)]
        [TestCase(0, 0)]
        public void Test1()
        {
            int tst = Operations.Add(a, b);
            Assert.AreEqual(a + b, tst);
        }
    }
}
