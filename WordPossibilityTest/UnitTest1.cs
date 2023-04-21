using Boggle_CSCE_361.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordPossibilityTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RegularTest1()
        {
            WordPossibilityController controller = new WordPossibilityController();
            char[,] boggleGrid = { { 'q', 'a', 'o', 'r' },
                                   { 'i', 'c', 'e', 'f' },
                                   { 'k', 'u', 'r', 'n' },
                                   { 'f', 'i', 'l', 'e' } };

            String word = "ore";

            Assert.AreEqual(controller.isWordPossibleGrid(boggleGrid, word));
        }
    }
}