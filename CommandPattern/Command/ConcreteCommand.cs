
namespace CommandPattern.Command
{
    internal class ConcreteCommand : ICommand
    {
        private readonly Receiver.Receiver _receiver;

        public bool Success { get; set; }

        public ConcreteCommand(Receiver.Receiver receiver)
        {
            _receiver = receiver;
        }              

        public void Execute()
        {
            _receiver.Action();
            Success = true;
        }
    }
}
