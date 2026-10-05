
using CommandPattern.Command;

namespace CommandPattern.Invoker
{
    public class Invoker
    {
        private readonly IList<ICommand> _commands;

        public Invoker() => _commands = new List<ICommand>();

        public void SetCommand(ICommand command) => _commands.Add(command);

        public bool ExecuteCommands()
        {
            var success = true;

            foreach (var command in _commands) 
            {
                command.Execute();
                success &= command.Success;
            }

            return success;
        }
    }
}
