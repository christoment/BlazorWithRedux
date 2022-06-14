namespace BlazorWithRedux.States.Counter
{
    public record IncreaseCounter {
        public int Step { get; set; } = 1;
    }
}
