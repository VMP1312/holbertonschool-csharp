using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Palindro()
        {
            bool isP = Str.IsPalindrome("Racecar");
            Assert.IsTrue(isP);
        }

        [Test]
        public void NotPalin()
        {
            bool isP = Str.IsPalindrome("Nadie silva");
            Assert.IsFalse(isP);
        }

        [Test]
        public void Empty()
        {
            bool isP = Str.IsPalindrome("");
            Assert.IsTrue(isP);
        }

         public void punctuationTrue()
        {
           bool isP = Str.IsPalindrome("A man, a plan, a canal: Panama.");
           Assert.IsTrue(isP);
        }
        [Test]
        public void SpacesTrue()
        {
           bool isP = Str.IsPalindrome("A man, a plan,\n a canal: Panama.\t");
           Assert.IsTrue(isP);
        }
        [Test]
        public void Megafalse()
        {
           bool isP = Str.IsPalindrome("a man, a plan,\n a canal\t");
           Assert.IsFalse(isP);
    }
}
