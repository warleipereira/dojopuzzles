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
            var input = "JEDI";

            var solution = new Anagramas();

            var anagramas = solution.GetAnagramas(input);

            Assert.IsTrue(anagramas.Count == solution.GetFatorial(input.Length));

            Assert.IsTrue(solution.IsAllDistinct(anagramas));
        }
    }
}