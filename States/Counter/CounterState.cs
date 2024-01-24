using Fluxor;

namespace BlazorWithRedux.States.Counter;

[FeatureState]
public record CounterState
{
    public int Count { get; init; }
}
