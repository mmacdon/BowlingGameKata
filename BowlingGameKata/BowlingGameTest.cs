using Xunit;

namespace BowlingGameKata;
public class BowlingGameTest
{

    private readonly Game _game = new Game();
    [Fact]
    public void TestGutterGame()
    {
        RollMany(20, 0);
        Assert.Equal(0, _game.Score());
    }

    private void RollMany(int n, int pins)
    {
        for (int i = 0; i < n; i++)
        {
            _game.Roll(pins);
        }
    }

    [Fact]
    public void TestAllOnes()
    {
        RollMany(20, 1);
        Assert.Equal(20, _game.Score());
    }

    [Fact]
    public void TestOneSpare()
    {
        RollSpare();
        _game.Roll(5);

        Assert.Equal(20, _game.Score());
    }

    private void RollSpare()
    {
        RollMany(2, 5);
    }

    [Fact]
    public void TestOneStrike()
    {
        _game.Roll(10);
        _game.Roll(5);
        _game.Roll(8);

        Assert.Equal(36, _game.Score());
    }
}
