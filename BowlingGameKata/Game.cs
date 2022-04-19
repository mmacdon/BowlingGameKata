using System.Linq;

namespace BowlingGameKata;
public class Game
{
    private int _currentRoll = 0;
    private int[] _rolls = new int[20];

    public void Roll(int pins)
    {
        _rolls[_currentRoll++] = pins;
    }

    public int Score()
    {
        int _score = 0;
        int rollIndex = 0;
        for(int frame = 0; frame < 10; frame++)
        {
            if(IsStrike(rollIndex))
            {
                _score += 10 + _rolls[rollIndex + 1] + _rolls[rollIndex + 2];
                rollIndex++;
            }
            else if (IsSpare(rollIndex))
            {
                _score += 10 + _rolls[rollIndex + 2];
                rollIndex += 2;
            }
            else
            {
                _score += _rolls[rollIndex] + _rolls[rollIndex + 1];
                rollIndex += 2;
            }
        }
        return _score;       
    }

    private bool IsStrike(int rollIndex)
    {
        return _rolls[rollIndex] == 10;
    }

    private bool IsSpare(int rollIndex)
    {
        return _rolls[rollIndex] + _rolls[rollIndex + 1] == 10;
    }


}