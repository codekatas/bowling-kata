using Machine.Specifications;

namespace Bowling.Test
{
    public class when_rolling_a_gutter_game : with_game
    {
        Because of = () =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Game.Roll(0);
                }
            };

        It should_score_zero_for_the_game = () => Game.Score.ShouldEqual(0);
    }

    public class with_game
    {
        Establish context = () => { Game = new Game(); };
        protected static Game Game;
    }
}