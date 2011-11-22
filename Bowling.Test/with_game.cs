using Machine.Specifications;

namespace Bowling.Test
{
    public class with_game
    {
        Establish context = () => { Game = new Game(); };
        protected static Game Game;

        protected static void RollMany(int times, int pins)
        {
            for (int i = 0; i < times; i++)
            {
                Game.Roll(pins);
            }
        }
    }
}