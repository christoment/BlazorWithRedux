using System;
using System.Threading.Tasks;
using Fluxor;

namespace BlazorWithRedux.States.Counter;

public class CounterEffects
{
    private readonly IState<CounterState> _counterState;

    // Can use injection
    public CounterEffects(IState<CounterState> counterState)
    {
        _counterState = counterState;
    }

    [EffectMethod]
    public Task LogIncreaseCounter(IncreaseCounter action, IDispatcher dispatcher)
    {
        Console.WriteLine($"Current count: {_counterState.Value.Count}. Counter increased with step {action.Step}");

        return Task.CompletedTask;
    }
}