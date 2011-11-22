using Machine.Specifications;

namespace Bowling.Test
{
    public class when_rolling_all_ones_game : with_game 
    {
        Because of = () =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Game.Roll(1);
                }
            };

        It should_score_zero_for_the_game = () => Game.Score.ShouldEqual(20);
    }
}