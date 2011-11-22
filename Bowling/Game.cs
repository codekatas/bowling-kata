namespace Bowling
{
    public class Game
    {
        public void Roll(int pins)
        {
            Score += pins;
        }

        public int Score { get; set; }
    }
}