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
            var input = "biro";

            var solution = new Anagrams();

            var anagramas = solution.GetAnagrams(input);

            Assert.IsTrue(anagramas.Count == solution.GetFactorial(input.Length));

            Assert.IsTrue(solution.IsAllDistinct(anagramas));
        }
    }
}