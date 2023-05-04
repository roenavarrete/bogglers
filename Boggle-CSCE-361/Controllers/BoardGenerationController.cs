namespace Boggle_CSCE_361.Controllers
{
	public class BoardGenerationController
	{

		public static readonly string[][] dice = new string[][]
		{
			new string[] { "R", "I", "F", "O", "B", "X" },
			new string[] { "H", "M", "S", "R", "A", "O" },
			new string[] { "Qu", "B", "M", "J", "O", "A" },
			new string[] { "E", "Z", "A", "V", "N", "D" },
			new string[] { "I", "F", "E", "H", "E", "Y" },
			new string[] { "L", "U", "P", "E", "T", "S" },
			new string[] { "E", "H", "I", "S", "P", "N" },
			new string[] { "R", "A", "L", "E", "S", "C" },
			new string[] { "D", "E", "N", "O", "W", "S" },
			new string[] { "A", "C", "I", "T", "O", "A" },
			new string[] { "V", "E", "T", "I", "G", "N" },
			new string[] { "U", "W", "I", "L", "R", "G" },
			new string[] { "U", "T", "O", "K", "N", "D" },
			new string[] { "Y", "L", "G", "K", "U", "E" },
			new string[] { "B", "A", "L", "I", "Y", "T" },
			new string[] { "P", "A", "C", "E", "M", "D" }
		};

		public static void Shuffle<T>(T[] array)
		{
			Random rng = new Random();
			int n = array.Length;
			while (n > 1)
			{
				int k = rng.Next(n--);
				T temp = array[n];
				array[n] = array[k];
				array[k] = temp;
			}
		}

		public static string[,] GenerateBoard()
		{
			string[,] board = new string[4, 4];

			// Shuffle the dice
			for (int i = 0; i < dice.Length; i++)
			{
				Shuffle(dice[i]);
			}

			// Roll the dice and fill the board
			int index = 0;
			for (int row = 0; row < 4; row++)
			{
				for (int col = 0; col < 4; col++)
				{
					string[] die = dice[index];
					board[row, col] = die[new Random().Next(die.Length)];
					index++;
				}
			}

			return board;
		}
	}
}
