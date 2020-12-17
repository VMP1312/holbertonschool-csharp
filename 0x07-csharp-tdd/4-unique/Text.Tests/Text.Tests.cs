using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class UniqueTests
    {

        [Test]
        public void Null()
        {
            string s = null;
            var res = Str.UniqueChar(s);
            Assert.AreEqual(-1, res);
        }

        [Test]
        public void Empty()
        {
            string s = "";
            var res = Str.UniqueChar(s);
            Assert.AreEqual(-1, res);
        }

        [Test]
        public void Find()
        {
            string s = "Prueeba";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(1, result);
        }
        
        [Test]
        public void Dont()
        {
            string s = "Hola";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
    }
}