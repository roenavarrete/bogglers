using Boggle_CSCE_361.Controllers.Interfaces;

namespace Boggle_CSCE_361.Controllers.Controllers
{
    public class WordScorerController : IWordScorerController
    {
        public int getScore(string word)
        {
            switch (word.Length)
            {
                case 0:
                    return 0;
                case 1:
                    return 0;
                case 2:
                    return 0;
                case 3:
                    return 1;
                case 4:
                    return 1;
                case 5:
                    return 2;
                case 6:
                    return 3;
                case 7:
                    return 5;
                default:
                    return 11;
            }
        }
    }
}
