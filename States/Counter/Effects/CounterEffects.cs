using System;
using System.Threading.Tasks;
using BlazorWithRedux.States.Counter.Actions;
using Fluxor;

namespace BlazorWithRedux.States.Counter.Effects
{
    public class CounterEffects
    {
        // Can use injection

        [EffectMethod]
        public Task LogIncreaseCounter(IncreaseCounter action, IDispatcher dispatcher)
        {
            Console.WriteLine($"Counter increased with step {action.Step}");

            return Task.CompletedTask;
        }
    }
}