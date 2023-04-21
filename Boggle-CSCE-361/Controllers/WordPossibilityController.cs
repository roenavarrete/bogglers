using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace Boggle_CSCE_361.Controllers
{
    public class WordPossibilityController : Controller
    {
        /**
         * 
         * Checks if a word is possible where the starting letter is at indices startRow and startColumn within the grid.
         * 
         * Uses recursion to recurse through all the possible routes from the letter.
         * Expects "q" in the grid to be treated as "qu".
         * 
         * Returns true if the word is possible at the starting indices.
         * Returns false if the word is impossible at the starting indices.
         * 
         **/
        public bool isWordPossibleHere(String word, char[,] grid, int startRow, int startColumn, int letterIndex)
        {
            if (word.Length == letterIndex)
            {
                return true;
            }
            else if (startRow < 0 || startRow >= grid.Length || startColumn < 0 || startColumn >= grid[0].Length)
            {
                return false;
            }
            else if (grid[startRow][startColumn] != word[letterIndex])
            {
                return false;
            }

            char newGrid[grid.Length][grid[0].Length];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    newGrid[i][j] = grid[i][j];
                }
            }
            newGrid[startRow][startColumn] = '$';

            int newLetterIndex = letterIndex + 1;
            if (grid[startRow][startColumn] == 'q' || grid[startRow][startColumn] == 'Q')
            {
                newLetterIndex++;
            }

            bool up = isWordPossibleHere(word, newGrid, startRow - 1, startColumn, newLetterIndex);
            bool upRight = isWordPossibleHere(word, newGrid, startRow - 1, startColumn + 1, newLetterIndex);
            bool right = isWordPossibleHere(word, newGrid, startRow, startColumn + 1, newLetterIndex);
            bool downRight = isWordPossibleHere(word, newGrid, startRow + 1, startColumn + 1, newLetterIndex);
            bool down = isWordPossibleHere(word, newGrid, startRow + 1, startColumn, newLetterIndex);
            bool downLeft = isWordPossibleHere(word, newGrid, startRow + 1, startColumn - 1, newLetterIndex);
            bool left = isWordPossibleHere(word, newGrid, startRow, startColumn - 1, newLetterIndex);
            bool upLeft = isWordPossibleHere(word, newGrid, startRow - 1, startColumn - 1, newLetterIndex);

            bool foundNextLetter = up || upRight || right || downRight || down || downLeft || left || upLeft;

            return foundNextLetter;
        }

        /**
         * 
         * Uses the isWordPossibleHere() function.
         * Loops over the whole grid to check if the word is possible at each index.
         * If the word length is less than 3, the word is automatically considered false.
         * If the word is not within the database, the word is automatically considered false.
         * 
         **/
        public bool isWordPossibleGrid(char[,] grid, String word)
        {
            if (word.Length < 3)
            {
                return false;
            }
            //if (!boggleWordDatabase.Contains(word)) { return false; }
            for (int row = 0; row < grid.Length; row++)
            {
                for (int column = 0; column < grid[row].Length; column++)
                {
                    if (isWordPossibleHere(grid, word, row, column, 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
