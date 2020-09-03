using System;
using System.Threading.Tasks;
using BlazorWithRedux.States.Counter.Actions;
using Fluxor;

namespace BlazorWithRedux.States.Counter.Effects
{
    public class CounterEffects
    {
        private readonly IState<CounterState> counterState;

        // Can use injection
        public CounterEffects(IState<CounterState> counterState)
        {
            this.counterState = counterState;
        }

        [EffectMethod]
        public Task LogIncreaseCounter(IncreaseCounter action, IDispatcher dispatcher)
        {
            Console.WriteLine($"Current count: {counterState.Value.Count}. Counter increased with step {action.Step}");

            return Task.CompletedTask;
        }
    }
}