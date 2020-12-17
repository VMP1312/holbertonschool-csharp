using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Palindro()
        {
            bool isP = Str.IsPalindrome("Luz azul");
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
    }
}
