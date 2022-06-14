using Fluxor;

namespace BlazorWithRedux.States.Counter
{
    public static class CounterReducer
    {
        [ReducerMethod]
        public static CounterState OnIncreaseCounter(CounterState state, IncreaseCounter action) => state with
        {
            Count = state.Count + action.Step
        };
    }
}