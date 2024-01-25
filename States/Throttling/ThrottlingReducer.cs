using Fluxor;

namespace BlazorWithRedux.States.Throttling;

public static class ThrottlingReducer
{
    [ReducerMethod]
    public static ThrottlingState OnTriggerThrottlingCounter(ThrottlingState state, TriggerThrottlingCounter action) => state with
    {
        UnthrottledCount = state.UnthrottledCount + 1
    };
}
