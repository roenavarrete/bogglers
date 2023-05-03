namespace Boggle_CSCE_361.Models;

public class DiceVerifier
{
    private readonly Dictionary<string, int> _letterFrequencies = new();
    private readonly Dictionary<string, HashSet<int>> _diceReverseLookup = new();
    private readonly int _numDice;
    private readonly int _maximumTokenLength;

    public DiceVerifier(List<List<string>> dicePool)
    {
        _numDice = dicePool.Count;
        _maximumTokenLength = 0;
        for (var index = 0; index < dicePool.Count; index++)
        {
            var dice = dicePool[index];
            foreach (var token in dice)
            {
                if (!_letterFrequencies.ContainsKey(token))
                {
                    _letterFrequencies[token] = 0;
                    if (token.Length > _maximumTokenLength)
                    {
                        _maximumTokenLength = token.Length;
                    }
                }
                
                _letterFrequencies[token] += 1;

                if (!_diceReverseLookup.ContainsKey(token))
                {
                    _diceReverseLookup[token] = new();
                }
                
                _diceReverseLookup[token].Add(index);
            }
        }
    }

    public bool IsPossibleWord(string word)
    {
        // Filter 1: Word is too long
        if (word.Length > _numDice)
        {
            return false;
        }
        
        // Operation: Generate the list of tokens naively
        List<string> tokens = new();
        {
            string? workingToken = null;
            foreach (var token in word.Select(c => workingToken is null ? c.ToString() : workingToken + c))
            {
                if (_letterFrequencies.ContainsKey(token))
                {
                    tokens.Add(token);
                    workingToken = null;
                }
                else if (token.Length >= _maximumTokenLength)
                {
                    return false;
                }
                else
                {
                    workingToken = token;
                }
            }
        }
        
        // Filter 2: letters appear too often
        {
            Dictionary<string, int> tokenCounts = new();
            foreach (var token in tokens)
            {
                if (!tokenCounts.ContainsKey(token)) 
                {
                    tokenCounts[token] = 0;
                }
                tokenCounts[token] += 1;
            }
            foreach (var (token, frequency) in tokenCounts)
            {
                if (frequency > _letterFrequencies[token])
                {
                    return false;
                }
            }
        }

        // Filter 3: Not possible with the dice available.
        var rows = tokens.Count;
        var matrixTime = new bool[rows, _numDice];
        for (var i = 0; i < tokens.Count; i++)
        {
            foreach (var x in _diceReverseLookup[tokens[i]])
            {
                matrixTime[i, x] = true;
            }
        }

        return !AreAnyInsufficient(rows, matrixTime);
    }

    private bool AreAnyInsufficient(int numOfTokens, bool[,] matrix)
    {
        return AreAnyInsufficient(numOfTokens, 0, matrix, new HashSet<int>());
    }

    private bool AreAnyInsufficient(int numOfTokens, int startValue, bool[,] matrix, HashSet<int> ongoing)
    {
        for (var i = startValue; i < numOfTokens; i++)
        {
            var personalCopy = new HashSet<int>(ongoing) { i };
            if (!DoesUnionHaveMore(personalCopy, matrix) ||
                AreAnyInsufficient(numOfTokens, i + 1, matrix, personalCopy))
            {
                return true;
            }
        }
        return false;
    }

    private bool DoesUnionHaveMore(HashSet<int> subset, bool[,] matrix)
    {
        var count = 0;
        for (var i = 0; i < _numDice; i++)
        {
            var overlap = subset.Aggregate(false, (current, c) => current || matrix[c, i]);
            if (overlap) { count++; }
        }

        return count >= subset.Count;
    }
}