using Boggle_CSCE_361.Controllers;

namespace Tests
{
    public class WordPossibilityTests
    {
        public void ValidTest1() {

            String[,] boggleGrid = { { "qu", "a", "o", "r" },
                                       { "i", "c", "e", "f" },
                                       { "k", "u", "r", "n" },
                                       { "f", "i", "l", "e" } };

            IWordPossibilityController controller = new WordPossibilityController();

            String word1 = "ore";
            String word2 = "quick";
            String word3 = "filer";
            String word4 = "urn";
            String word5 = "fern";

            bool testResult = true;
            bool actualResult1 = controller.isWordPossibleGrid(boggleGrid, word1);
            bool actualResult2 = controller.isWordPossibleGrid(boggleGrid, word2);
            bool actualResult3 = controller.isWordPossibleGrid(boggleGrid, word3);
            bool actualResult4 = controller.isWordPossibleGrid(boggleGrid, word4);
            bool actualResult5 = controller.isWordPossibleGrid(boggleGrid, word5);
            

            if (!actualResult1)
            {
                Console.WriteLine("Failed ValidTest1.1!");
                testResult = false;
            }
            if (!actualResult2)
            {
                Console.WriteLine("Failed ValidTest1.2!");
                testResult = false;
            }
            if (!actualResult3)
            {
                Console.WriteLine("Failed ValidTest1.3!");
                testResult = false;
            }
            if (!actualResult4)
            {
                Console.WriteLine("Failed ValidTest1.4!");
                testResult = false;
            }
            if (!actualResult5)
            {
                Console.WriteLine("Failed ValidTest1.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("ValidTest1 passed!");
            }

        }

        public void ValidTest2()
        {
            String[,] boggleGrid = { { "d", "s", "r", "s" },
                                       { "o", "g", "a", "n" },
                                       { "i", "l", "h", "i" },
                                       { "h", "d", "t", "qu" } };

            WordPossibilityController controller = new WordPossibilityController();

            String word1 = "oil";
            String word2 = "gains";
            String word3 = "tins";
            String word4 = "dog";
            String word5 = "soil";

            bool testResult = true;
            bool actualResult1 = controller.isWordPossibleGrid(boggleGrid, word1);
            bool actualResult2 = controller.isWordPossibleGrid(boggleGrid, word2);
            bool actualResult3 = controller.isWordPossibleGrid(boggleGrid, word3);
            bool actualResult4 = controller.isWordPossibleGrid(boggleGrid, word4);
            bool actualResult5 = controller.isWordPossibleGrid(boggleGrid, word5);


            if (!actualResult1)
            {
                Console.WriteLine("Failed ValidTest2.1!");
                testResult = false;
            }
            if (!actualResult2)
            {
                Console.WriteLine("Failed ValidTest2.2!");
                testResult = false;
            }
            if (!actualResult3)
            {
                Console.WriteLine("Failed ValidTest2.3!");
                testResult = false;
            }
            if (!actualResult4)
            {
                Console.WriteLine("Failed ValidTest2.4!");
                testResult = false;
            }
            if (!actualResult5)
            {
                Console.WriteLine("Failed ValidTest2.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("ValidTest2 passed!");
            }
        }

        public void ValidTest3()
        {
            String[,] boggleGrid = { { "d", "b", "u", "l" },
                                       { "a", "e", "c", "h" },
                                       { "l", "n", "i", "i" },
                                       { "t", "o", "e", "s" } };

            WordPossibilityController controller = new WordPossibilityController();

            String word1 = "toes";
            String word2 = "nice";
            String word3 = "toned";
            String word4 = "tonal";
            String word5 = "sicineotlabdeulh";

            bool testResult = true;
            bool actualResult1 = controller.isWordPossibleGrid(boggleGrid, word1);
            bool actualResult2 = controller.isWordPossibleGrid(boggleGrid, word2);
            bool actualResult3 = controller.isWordPossibleGrid(boggleGrid, word3);
            bool actualResult4 = controller.isWordPossibleGrid(boggleGrid, word4);
            bool actualResult5 = controller.isWordPossibleGrid(boggleGrid, word5);


            if (!actualResult1)
            {
                Console.WriteLine("Failed ValidTest3.1!");
                testResult = false;
            }
            if (!actualResult2)
            {
                Console.WriteLine("Failed ValidTest3.2!");
                testResult = false;
            }
            if (!actualResult3)
            {
                Console.WriteLine("Failed ValidTest3.3!");
                testResult = false;
            }
            if (!actualResult4)
            {
                Console.WriteLine("Failed ValidTest3.4!");
                testResult = false;
            }
            if (!actualResult5)
            {
                Console.WriteLine("Failed ValidTest3.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("ValidTest3 passed!");
            }
        }

        public void InvalidTest1()
        {
            String[,] boggleGrid = { { "qu", "a", "o", "r" },
                                       { "i", "c", "e", "f" },
                                       { "k", "u", "r", "n" },
                                       { "f", "i", "l", "e" } };

            WordPossibilityController controller = new WordPossibilityController();

            String word1 = "liar";
            String word2 = "notaword";
            String word3 = "nicholas";
            String word4 = "icicle";
            String word5 = "roel";

            bool testResult = true;
            bool actualResult1 = controller.isWordPossibleGrid(boggleGrid, word1);
            bool actualResult2 = controller.isWordPossibleGrid(boggleGrid, word2);
            bool actualResult3 = controller.isWordPossibleGrid(boggleGrid, word3);
            bool actualResult4 = controller.isWordPossibleGrid(boggleGrid, word4);
            bool actualResult5 = controller.isWordPossibleGrid(boggleGrid, word5);


            if (actualResult1)
            {
                Console.WriteLine("Failed InvalidTest1.1!");
            }
            if (actualResult2)
            {
                Console.WriteLine("Failed InvalidTest1.2!");
            }
            if (actualResult3)
            {
                Console.WriteLine("Failed InvalidTest1.3!");
            }
            if (actualResult4)
            {
                Console.WriteLine("Failed InvalidTest1.4!");
            }
            if (actualResult5)
            {
                Console.WriteLine("Failed InvalidTest1.5!");
            }

            if (testResult)
            {
                Console.WriteLine("InvalidTest1 passed!");
            }
        }

        public void InvalidTest2()
        {
            String[,] boggleGrid = { { "d", "s", "r", "s" },
                                       { "o", "g", "a", "n" },
                                       { "i", "l", "h", "i" },
                                       { "h", "d", "t", "qu" } };

            WordPossibilityController controller = new WordPossibilityController();

            String word1 = "oiled";
            String word2 = "gainer";
            String word3 = "laufey";
            String word4 = "roenavarreteatbpsnebrorg";
            String word5 = "asapspacesrocky";

            bool testResult = true;
            bool actualResult1 = controller.isWordPossibleGrid(boggleGrid, word1);
            bool actualResult2 = controller.isWordPossibleGrid(boggleGrid, word2);
            bool actualResult3 = controller.isWordPossibleGrid(boggleGrid, word3);
            bool actualResult4 = controller.isWordPossibleGrid(boggleGrid, word4);
            bool actualResult5 = controller.isWordPossibleGrid(boggleGrid, word5);


            if (actualResult1)
            {
                Console.WriteLine("Failed InvalidTest2.1!");
                testResult = false;
            }
            if (actualResult2)
            {
                Console.WriteLine("Failed InvalidTest2.2!");
                testResult = false;
            }
            if (actualResult3)
            {
                Console.WriteLine("Failed InvalidTest2.3!");
                testResult = false;
            }
            if (actualResult4)
            {
                Console.WriteLine("Failed InvalidTest2.4!");
                testResult = false;
            }
            if (actualResult5)
            {
                Console.WriteLine("Failed InvalidTest2.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("InvalidTest2 passed!");
            }
        }

        public void InvalidTest3()
        {
            String[,] boggleGrid = { { "d", "b", "u", "l" },
                                       { "a", "e", "c", "h" },
                                       { "l", "n", "i", "i" },
                                       { "t", "o", "e", "s" } };

            WordPossibilityController controller = new WordPossibilityController();

            String word1 = "dalel";
            String word2 = "buns";
            String word3 = "iceii";
            String word4 = "sickle";
            String word5 = "tnolaedbculhiseio";

            bool testResult = true;
            bool actualResult1 = controller.isWordPossibleGrid(boggleGrid, word1);
            bool actualResult2 = controller.isWordPossibleGrid(boggleGrid, word2);
            bool actualResult3 = controller.isWordPossibleGrid(boggleGrid, word3);
            bool actualResult4 = controller.isWordPossibleGrid(boggleGrid, word4);
            bool actualResult5 = controller.isWordPossibleGrid(boggleGrid, word5);


            if (actualResult1)
            {
                Console.WriteLine("Failed InvalidTest3.1!");
                testResult = false;
            }
            if (actualResult2)
            {
                Console.WriteLine("Failed InvalidTest3.2!");
                testResult = false;
            }
            if (actualResult3)
            {
                Console.WriteLine("Failed InvalidTest3.3!");
                testResult = false;
            }
            if (actualResult4)
            {
                Console.WriteLine("Failed InvalidTest3.4!");
                testResult = false;
            }
            if (actualResult5)
            {
                Console.WriteLine("Failed InvalidTest3.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("InvalidTest3 passed!");
            }
        }

        public void MixedTest1()
        {
            String[,] boggleGrid = { { "qu", "a", "o", "r" },
                                       { "i", "c", "e", "f" },
                                       { "k", "u", "r", "n" },
                                       { "f", "i", "l", "e" } };

            WordPossibilityController controller = new WordPossibilityController();

            String word1 = "for";
            String word2 = "foe";
            String word3 = "earn";
            String word4 = "quack";
            String word5 = "qik";

            bool testResult = true;
            bool actualResult1 = controller.isWordPossibleGrid(boggleGrid, word1);
            bool actualResult2 = controller.isWordPossibleGrid(boggleGrid, word2);
            bool actualResult3 = controller.isWordPossibleGrid(boggleGrid, word3);
            bool actualResult4 = controller.isWordPossibleGrid(boggleGrid, word4);
            bool actualResult5 = controller.isWordPossibleGrid(boggleGrid, word5);


            if (!actualResult1)
            {
                Console.WriteLine("Failed MixedTest1.1!");
                testResult = false;
            }
            if (!actualResult2)
            {
                Console.WriteLine("Failed MixedTest1.2!");
                testResult = false;
            }
            if (actualResult3)
            {
                Console.WriteLine("Failed MixedTest1.3!");
                testResult = false;
            }
            if (!actualResult4)
            {
                Console.WriteLine("Failed MixedTest1.4!");
                testResult = false;
            }
            if (actualResult5)
            {
                Console.WriteLine("Failed MixedTest1.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("MixedTest1 passed!");
            }
        }

        public void MixedTest2()
        {
            String[,] boggleGrid = { { "d", "s", "r", "s" },
                                       { "o", "g", "a", "n" },
                                       { "i", "l", "h", "i" },
                                       { "h", "d", "t", "qu" } };

            WordPossibilityController controller = new WordPossibilityController();

            String word1 = "sale";
            String word2 = "grass";
            String word3 = "thasrag";
            String word4 = "gas";
            String word5 = "than";

            bool testResult = true;
            bool actualResult1 = controller.isWordPossibleGrid(boggleGrid, word1);
            bool actualResult2 = controller.isWordPossibleGrid(boggleGrid, word2);
            bool actualResult3 = controller.isWordPossibleGrid(boggleGrid, word3);
            bool actualResult4 = controller.isWordPossibleGrid(boggleGrid, word4);
            bool actualResult5 = controller.isWordPossibleGrid(boggleGrid, word5);


            if (actualResult1)
            {
                Console.WriteLine("Failed MixedTest2.1!");
                testResult = false;
            }
            if (actualResult2)
            {
                Console.WriteLine("Failed MixedTest2.2!");
                testResult = false;
            }
            if (actualResult3)
            {
                Console.WriteLine("Failed MixedTest2.3!");
                testResult = false;
            }
            if (!actualResult4)
            {
                Console.WriteLine("Failed MixedTest2.4!");
                testResult = false;
            }
            if (!actualResult5)
            {
                Console.WriteLine("Failed MixedTest2.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("MixedTest2 passed!");
            }
        }

        public void MixedTest3()
        {
            String[,] boggleGrid = { { "d", "b", "u", "l" },
                                       { "a", "e", "c", "h" },
                                       { "l", "n", "i", "i" },
                                       { "t", "o", "e", "s" } };

            WordPossibilityController controller = new WordPossibilityController();

            String word1 = "sonar";
            String word2 = "lucky";
            String word3 = "lane";
            String word4 = "dab";
            String word5 = "gopal";

            bool testResult = true;
            bool actualResult1 = controller.isWordPossibleGrid(boggleGrid, word1);
            bool actualResult2 = controller.isWordPossibleGrid(boggleGrid, word2);
            bool actualResult3 = controller.isWordPossibleGrid(boggleGrid, word3);
            bool actualResult4 = controller.isWordPossibleGrid(boggleGrid, word4);
            bool actualResult5 = controller.isWordPossibleGrid(boggleGrid, word5);


            if (actualResult1)
            {
                Console.WriteLine("Failed MixedTest3.1!");
                testResult = false;
            }
            if (actualResult2)
            {
                Console.WriteLine("Failed MixedTest3.2!");
                testResult = false;
            }
            if (!actualResult3)
            {
                Console.WriteLine("Failed MixedTest3.3!");
                testResult = false;
            }
            if (!actualResult4)
            {
                Console.WriteLine("Failed MixedTest3.4!");
                testResult = false;
            }
            if (actualResult5)
            {
                Console.WriteLine("Failed MixedTest3.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("MixedTest3 passed!");
            }
        }

    }
}