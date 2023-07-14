
using Palindromes;

namespace PalindromesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string inputString = "abcde";
            string reverseString = PalindromesCheck.Reverse(inputString);
            Assert.AreEqual(reverseString, "edcba");
        }

        [TestMethod]
        public void TestMethod2()
        {
            string inputString = "AbcBa";
            string reverseString = PalindromesCheck.Reverse(inputString);
            Assert.AreNotEqual(reverseString, "abcba");
        }
    }
}