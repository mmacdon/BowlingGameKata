using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BowlingGameKata
{
    public class BowlingGameTest
    {

        private readonly Game _game = new Game();
        [Fact]
        public void TestGutterGame()
        {
            for(int i = 0; i < 10; i++)
            {
                _game.Roll(0);
            }
            Assert.Equal(0, _game.Score());
        }

        [Fact]
        public void TestAllOnes()
        {
            for (int i = 0; i < 20; i++)
            {
                _game.Roll(1);
            }
            Assert.Equal(20, _game.Score());
        }
    }
}
