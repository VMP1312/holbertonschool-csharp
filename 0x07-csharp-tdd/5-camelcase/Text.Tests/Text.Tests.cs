using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Empty()
        {
            string s = "";
            var result = Str.CamelCase(s);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Null()
        {
            string s = null;
            var result = Str.CamelCase(s);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Find()
        {
            string s = "estaEsUnaPrueba";
            var result = Str.CamelCase(s);
            Assert.AreEqual(4, result);
        }
    }
}
