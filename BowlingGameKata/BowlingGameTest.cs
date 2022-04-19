using Xunit;

namespace BowlingGameKata
{
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
            for(int i = 0;i < n; i++)
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
    }
}
