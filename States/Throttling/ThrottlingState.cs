using Fluxor;

namespace BlazorWithRedux.States.Throttling;

[FeatureState]
public record ThrottlingState
{
    public int UnthrottledCount { get; init; } = 0;
}