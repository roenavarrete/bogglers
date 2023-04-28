namespace Boggle_CSCE_361.Controllers
{
    public class WordPossibilityController : IWordPossibilityController
    {
        public bool isWordPossibleHere(String word, String[,] grid, int startRow, int startColumn, int letterIndex)
        {
            if (word.Length == letterIndex)
            {
                return true;
            }
            else if (startRow < 0 || startRow >= grid.GetUpperBound(1) + 1 || startColumn < 0 || startColumn >= grid.GetUpperBound(0) + 1)
            {
                return false;
            }
            else if (!grid[startRow, startColumn].ToString().Contains((word[letterIndex])))
            {
                return false;
            }

            String[,] newGrid = grid.Clone() as String[,];
            newGrid[startRow, startColumn] = "$";

            int newLetterIndex = letterIndex + 1;
            if (grid[startRow, startColumn].ToString().Contains('q') || grid[startRow, startColumn].ToString().Contains('Q'))
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

        public bool isWordPossibleGrid(String[,] grid, String word)
        {
            if (word.Length < 3)
            {
                return false;
            }
            for (int row = 0; row < grid.GetUpperBound(1) + 1; row++)
            {
                for (int column = 0; column < grid.GetUpperBound(0) + 1; column++)
                {
                    if (isWordPossibleHere(word, grid, row, column, 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
