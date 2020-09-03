namespace BlazorWithRedux.States.Counter.Actions
{
    public record IncreaseCounter {
        public int Step { get; set; } = 1;
    }
}
