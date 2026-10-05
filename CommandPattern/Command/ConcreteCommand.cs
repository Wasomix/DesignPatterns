
namespace CommandPattern.Command
{
    internal class ConcreteCommand : ICommand
    {
        private readonly Receiver.IReceiver _receiver;

        public bool Success { get; set; }

        public ConcreteCommand(Receiver.IReceiver receiver)
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
