using System;
using Machine.Specifications;

namespace Bowling.Test
{
    [Ignore("Not testing this yet")]
    public class when_rolling_too_many_balls : with_game 
    {
        Because of = () =>
            {
                _exception=Catch.Exception(()=> RollMany(22, 0));
            };

        It should_score_zero_for_the_game = () => _exception.ShouldNotBeNull();
        static Exception _exception;
    }
}