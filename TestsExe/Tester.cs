using Tests;
WordPossibilityTests wordPossibilityTester = new WordPossibilityTests();
wordPossibilityTester.ValidTest1();
wordPossibilityTester.ValidTest2();
wordPossibilityTester.ValidTest3();
wordPossibilityTester.InvalidTest1();
wordPossibilityTester.InvalidTest2();
wordPossibilityTester.InvalidTest3();
wordPossibilityTester.MixedTest1();
wordPossibilityTester.MixedTest2();
wordPossibilityTester.MixedTest3();
Console.WriteLine("WordPossibility Testing Finished.\n");

WordScorerTests wordScorerTester = new WordScorerTests();
wordScorerTester.ThreeLetterTest();
wordScorerTester.FourLetterTest();
wordScorerTester.FiveLetterTest();
wordScorerTester.SixLetterTest();
wordScorerTester.SevenLetterTest();
wordScorerTester.EightOrMoreLetterTest();
Console.WriteLine("WordScorer Testing Finished.\n");

