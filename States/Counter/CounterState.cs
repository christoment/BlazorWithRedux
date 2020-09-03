using Fluxor;

namespace BlazorWithRedux.States.Counter
{
    public record CounterState
    {
        public int Count { get; init; }
    }

    public class CounterFeatureState : Feature<CounterState>
    {
        public override string GetName() => nameof(CounterState);

        protected override CounterState GetInitialState() => new CounterState
        {
            Count = 0,
        };
    }
}
