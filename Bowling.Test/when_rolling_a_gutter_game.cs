using Machine.Specifications;

namespace Bowling.Test
{
    public class when_rolling_a_gutter_game : with_game
    {
        Because of = () => RollMany(20, 0);

        It should_score_zero_for_the_game = () => Game.Score().ShouldEqual(0);
    }
}