using Machine.Specifications;

namespace Bowling.Test
{
    public class when_rolling_one_spare : with_game 
    {
        Because of = () =>
            {
                Game.Roll(5);
                Game.Roll(5); //spare
                Game.Roll(3);
                RollMany(17, 0);
            };

        It should_score_zero_for_the_game = () => Game.Score().ShouldEqual(16);
    }
}