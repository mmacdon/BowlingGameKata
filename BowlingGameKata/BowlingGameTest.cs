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
        RollStrike();
        _game.Roll(5);
        _game.Roll(8);

        Assert.Equal(36, _game.Score());
    }

    [Fact]
    public void TestTenthFrameStrike()
    {
        RollMany(18, 1);
        RollStrike();
        _game.Roll(2);
        _game.Roll(3);


        Assert.Equal(33, _game.Score());
    }

    private void RollStrike()
    {
        _game.Roll(10);
    }

    [Fact]
    public void TestTenthFrameSpare()
    {
        RollMany(18, 1);
        _game.Roll(5);
        _game.Roll(5);
        _game.Roll(3);


        Assert.Equal(31, _game.Score());
    }

    [Fact]
    public void TestPerfectGame()
    {
        RollMany(12, 10);

        Assert.Equal(300, _game.Score());
    }

}
