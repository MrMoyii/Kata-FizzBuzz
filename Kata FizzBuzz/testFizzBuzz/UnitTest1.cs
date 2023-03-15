using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata_FizzBuzz;
namespace testFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] testList = Program.Kata_FizzBuzz();
            Assert.AreEqual("Fizz", testList[2]);
            Assert.AreEqual("Buzz", testList[4]);
            Assert.AreEqual("FizzBuzz", testList[14]);
        }
    }
}
