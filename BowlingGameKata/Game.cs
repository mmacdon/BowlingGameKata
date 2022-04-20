namespace BowlingGameKata;
public class Game
{
    private int _currentRoll = 0;
    private int[] _rolls = new int[21];

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
                _score += 10 + StrikeBonus(rollIndex);
                rollIndex++;
            }
            else if (IsSpare(rollIndex))
            {
                _score += 10 + SpareBonus(rollIndex);
                rollIndex += 2;
            }
            else
            {
                _score += FrameScore(rollIndex);
                rollIndex += 2;
            }
        }
        return _score;       
    }

    private int FrameScore(int rollIndex)
    {
        return _rolls[rollIndex] + _rolls[rollIndex + 1];
    }

    private int SpareBonus(int rollIndex)
    {
        return _rolls[rollIndex + 2];
    }

    private int StrikeBonus(int rollIndex)
    {
        return _rolls[rollIndex + 1] + _rolls[rollIndex + 2];
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