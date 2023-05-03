using Boggle_CSCE_361.Controllers;

namespace Tests
{
    public class WordScorerTests
    {
        public void ThreeLetterTest()
        {
            IWordScorerController controller = new WordScorerController();

            String word1 = "rod";
            String word2 = "fur";
            String word3 = "dan";
            String word4 = "nic";
            String word5 = "quo";

            bool testResult = true;
            int actualResult1 = controller.getScore(word1);
            int actualResult2 = controller.getScore(word2);
            int actualResult3 = controller.getScore(word3);
            int actualResult4 = controller.getScore(word4);
            int actualResult5 = controller.getScore(word5);

            if (actualResult1 != 1)
            {
                Console.WriteLine("Failed ThreeLetterTest.1!");
                testResult = false;
            }
            if (actualResult2 != 1)
            {
                Console.WriteLine("Failed ThreeLetterTest.2!");
                testResult = false;
            }
            if (actualResult3 != 1)
            {
                Console.WriteLine("Failed ThreeLetterTest.3!");
                testResult = false;
            }
            if (actualResult4 != 1)
            {
                Console.WriteLine("Failed ThreeLetterTest.4!");
                testResult = false;
            }
            if (actualResult5 != 1)
            {
                Console.WriteLine("Failed ThreeLetterTest.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("ThreeLetterTest passed!");
            }
        }

        public void FourLetterTest()
        {
            IWordScorerController controller = new WordScorerController();

            String word1 = "rode";
            String word2 = "fire";
            String word3 = "roel";
            String word4 = "nich";
            String word5 = "goud";

            bool testResult = true;
            int actualResult1 = controller.getScore(word1);
            int actualResult2 = controller.getScore(word2);
            int actualResult3 = controller.getScore(word3);
            int actualResult4 = controller.getScore(word4);
            int actualResult5 = controller.getScore(word5);

            if (actualResult1 != 1)
            {
                Console.WriteLine("Failed FourLetterTest.1!");
                testResult = false;
            }
            if (actualResult2 != 1)
            {
                Console.WriteLine("Failed FourLetterTest.2!");
                testResult = false;
            }
            if (actualResult3 != 1)
            {
                Console.WriteLine("Failed FourLetterTest.3!");
                testResult = false;
            }
            if (actualResult4 != 1)
            {
                Console.WriteLine("Failed FourLetterTest.4!");
                testResult = false;
            }
            if (actualResult5 != 1)
            {
                Console.WriteLine("Failed FourLetterTest.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("FourLetterTest passed!");
            }
        }

        public void FiveLetterTest()
        {
            IWordScorerController controller = new WordScorerController();

            String word1 = "rover";
            String word2 = "steph";
            String word3 = "curry";
            String word4 = "three";
            String word5 = "point";

            bool testResult = true;
            int actualResult1 = controller.getScore(word1);
            int actualResult2 = controller.getScore(word2);
            int actualResult3 = controller.getScore(word3);
            int actualResult4 = controller.getScore(word4);
            int actualResult5 = controller.getScore(word5);

            if (actualResult1 != 2)
            {
                Console.WriteLine("Failed FiveLetterTest.1!");
                testResult = false;
            }
            if (actualResult2 != 2)
            {
                Console.WriteLine("Failed FiveLetterTest.2!");
                testResult = false;
            }
            if (actualResult3 != 2)
            {
                Console.WriteLine("Failed FiveLetterTest.3!");
                testResult = false;
            }
            if (actualResult4 != 2)
            {
                Console.WriteLine("Failed FiveLetterTest.4!");
                testResult = false;
            }
            if (actualResult5 != 2)
            {
                Console.WriteLine("Failed FiveLetterTest.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("FiveLetterTest passed!");
            }
        }

        public void SixLetterTest()
        {
            IWordScorerController controller = new WordScorerController();

            String word1 = "daniel";
            String word2 = "connor";
            String word3 = "witcig";
            String word4 = "saypaw";
            String word5 = "ghazia";

            bool testResult = true;
            int actualResult1 = controller.getScore(word1);
            int actualResult2 = controller.getScore(word2);
            int actualResult3 = controller.getScore(word3);
            int actualResult4 = controller.getScore(word4);
            int actualResult5 = controller.getScore(word5);

            if (actualResult1 != 3)
            {
                Console.WriteLine("Failed SixLetterTest.1!");
                testResult = false;
            }
            if (actualResult2 != 3)
            {
                Console.WriteLine("Failed SixLetterTest.2!");
                testResult = false;
            }
            if (actualResult3 != 3)
            {
                Console.WriteLine("Failed SixLetterTest.3!");
                testResult = false;
            }
            if (actualResult4 != 3)
            {
                Console.WriteLine("Failed SixLetterTest.4!");
                testResult = false;
            }
            if (actualResult5 != 3)
            {
                Console.WriteLine("Failed SixLetterTest.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("SixLetterTest passed!");
            }
        }

        public void SevenLetterTest()
        {
            IWordScorerController controller = new WordScorerController();

            String word1 = "watered";
            String word2 = "concave";
            String word3 = "electro";
            String word4 = "striker";
            String word5 = "pegasus";

            bool testResult = true;
            int actualResult1 = controller.getScore(word1);
            int actualResult2 = controller.getScore(word2);
            int actualResult3 = controller.getScore(word3);
            int actualResult4 = controller.getScore(word4);
            int actualResult5 = controller.getScore(word5);

            if (actualResult1 != 5)
            {
                Console.WriteLine("Failed SevenLetterTest.1!");
                testResult = false;
            }
            if (actualResult2 != 5)
            {
                Console.WriteLine("Failed SevenLetterTest.2!");
                testResult = false;
            }
            if (actualResult3 != 5)
            {
                Console.WriteLine("Failed SevenLetterTest.3!");
                testResult = false;
            }
            if (actualResult4 != 5)
            {
                Console.WriteLine("Failed SevenLetterTest.4!");
                testResult = false;
            }
            if (actualResult5 != 5)
            {
                Console.WriteLine("Failed SevenLetterTest.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("SevenLetterTest passed!");
            }
        }

        public void EightOrMoreLetterTest()
        {
            IWordScorerController controller = new WordScorerController();

            String word1 = "supercalifragilisticexpialidocious";
            String word2 = "electric";
            String word3 = "guitarist";
            String word4 = "skateboarder";
            String word5 = "rahhhhhhhhhhhhh";

            bool testResult = true;
            int actualResult1 = controller.getScore(word1);
            int actualResult2 = controller.getScore(word2);
            int actualResult3 = controller.getScore(word3);
            int actualResult4 = controller.getScore(word4);
            int actualResult5 = controller.getScore(word5);

            if (actualResult1 != 11)
            {
                Console.WriteLine("Failed EightOrMoreLetterTest.1!");
                testResult = false;
            }
            if (actualResult2 != 11)
            {
                Console.WriteLine("Failed EightOrMoreLetterTest.2!");
                testResult = false;
            }
            if (actualResult3 != 11)
            {
                Console.WriteLine("Failed EightOrMoreLetterTest.3!");
                testResult = false;
            }
            if (actualResult4 != 11)
            {
                Console.WriteLine("Failed EightOrMoreLetterTest.4!");
                testResult = false;
            }
            if (actualResult5 != 11)
            {
                Console.WriteLine("Failed EightOrMoreLetterTest.5!");
                testResult = false;
            }

            if (testResult)
            {
                Console.WriteLine("EightOrMoreLetterTest passed!");
            }
        }

    }
}
