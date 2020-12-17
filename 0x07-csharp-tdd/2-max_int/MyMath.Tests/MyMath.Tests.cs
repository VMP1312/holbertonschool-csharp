using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Operations_Tests
    {

        [Test]
        public void Empty()
        {
            List<int> nums = new List<int>();

            int maxi = Operations.Max(nums);
            Assert.AreEqual(0, maxi);
        }
        
        [Test]
        public void Null()
        {
            List<int> nums = null;

            int maxi = Operations.Max(nums);
            Assert.AreEqual(0, maxi);
        }

        [Test]
        public void Maxi()
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(-1);
            nums.Add(-2);

            int maxi = Operations.Max(nums);
            Assert.AreEqual(2, maxi);
        }
    }
}
