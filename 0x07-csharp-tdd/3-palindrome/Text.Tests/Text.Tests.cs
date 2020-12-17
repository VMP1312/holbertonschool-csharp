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
           string str = "a man. A plan. A canal: Panama";
           bool result = Str.IsPalindrome(str);
           Assert.IsTrue(result);
        }
        [Test]
        public void SpacesTrue()
        {
           string str = "a man. a plan.\n a canal: Panama.\t";
           bool result = Str.IsPalindrome(str);
           Assert.IsTrue(result);
        }
        [Test]
        public void Megafalse()
        {
           string str = "a man, a plan,\n a canal: Panamaa.\t";
           bool result = Str.IsPalindrome(str);
           Assert.IsFalse(result);
    }
}
