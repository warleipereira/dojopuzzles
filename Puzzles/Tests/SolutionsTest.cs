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

            Assert.IsTrue(solution.IsAllDistinct(anagrams), "There are repeated anagrams");
        }
    }
}