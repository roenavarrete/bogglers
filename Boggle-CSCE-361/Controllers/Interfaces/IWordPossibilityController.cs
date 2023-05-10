namespace Boggle_CSCE_361.Controllers.Interfaces
{
    public interface IWordPossibilityController
    {
        /*
         * Checks if a word is possible where the starting letter is at indices startRow and startColumn within the grid.
         * Uses recursion to recurse through all the possible routes from the letter.
         * Returns true if the word is possible at the starting indices. Otherwise, returns false.
         */
        bool isWordPossibleHere(string word, string[,] grid, int startRow, int startColumn, int letterIndex);

        /*
         * Uses the isWordPossibleHere() function.
         * Loops over the whole grid to check if the word is possible at each index.
         * If the word is found to be possible at one index, it will return true. Otherwise, returns false.
         */
        bool isWordPossibleGrid(string[,] grid, string word);
    }
}
