using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Palindro()
        {
            bool check = Str.IsPalindrome("Luz azul");
            Assert.IsTrue(check);
        }

        [Test]
        public void NotPalin()
        {
            bool check = Str.IsPalindrome("Nadie silva");
            Assert.IsFalse(check);
        }

        [Test]
        public void Empty()
        {
            bool check = Str.IsPalindrome("");
            Assert.IsTrue(check);
        }
    }
}
