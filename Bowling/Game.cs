using System.Collections.Generic;

namespace Bowling
{
    public class Game
    {
        public IList<int> Rolls { get; set; }

        public Game()
        {
            Rolls = new List<int>(21);
        }

        public void Roll(int pins)
        {
            Rolls.Add(pins);
        }

        public int Score()
        {
            var score = 0;
            var currentFrame = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                var frameScore = Rolls[currentFrame] + Rolls[currentFrame + 1];
                if (frameScore == 10)
                    score += Rolls[currentFrame + 2];
                score += frameScore;
                currentFrame += 2;
            }
            return score;
        }
    }
}