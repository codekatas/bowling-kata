using Machine.Specifications;

namespace Bowling.Test
{
    public class when_rolling_all_ones_game : with_game 
    {
        Because of = () => RollMany(20,1);

        It should_score_zero_for_the_game = () => Game.Score.ShouldEqual(20);
    }
}