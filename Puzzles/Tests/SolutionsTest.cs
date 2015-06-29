using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace Tests
{
    [TestClass]
    public class SolutionsTest
    {
        [TestMethod]
        public void AnagramasTest()
        {
            var input = "ABCD";

            var solution = new Anagrams();

            var anagrams = solution.GetAnagrams(input);

            Assert.IsTrue(anagrams.Count == solution.GetMaxAnagrams(input), "Invalid number of anagrams");
        }

        [TestMethod]
        public void CollatzTest()
        {
            var output = new Collatz().GetGreatestSequenceOrigin();

            Assert.IsTrue(true);
        }
    }
}