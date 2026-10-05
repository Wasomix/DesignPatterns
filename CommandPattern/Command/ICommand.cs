namespace CommandPattern.Command
{
    public interface ICommand
    {
        void Execute();
        public bool Success { get; set; }
    }
}
