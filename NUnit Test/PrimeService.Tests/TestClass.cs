using NUnit.Framework;
using TryCatch;

namespace Test.UnitTests.Services
{
    [TestFixture]
    public class TestClass
    {
        
        [Test]
        public void Test1()
        {
            var result = Program.Multiply();

            Assert.AreEqual(2, result);
        }

    }
}