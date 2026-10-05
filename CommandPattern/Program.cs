using CommandPattern.Command;
using CommandPattern.Exercise;

namespace CommandPattern;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("If you want to run example exercise, type E; otherwise press enter");
        var keyPreseed = Console.ReadKey();
        Console.WriteLine();

        if (keyPreseed.KeyChar == 'E')
        {
            RunExercise();
        }
        else
        {
            RunExample();
        }
    }

    private static void RunExample()
    {
        Receiver.IReceiver receiver = new Receiver.Receiver();
        ICommand commandOne = new ConcreteCommand(receiver);
        var invoker = new Invoker.Invoker();
        invoker.SetCommand(commandOne);
        invoker.ExecuteCommands();
    }

    private static void RunExercise()
    {
        var depositCommand = new Exercise.Command { TheAction = Exercise.Command.Action.Deposit, Amount = 200 };
        var withdrawCommand = new Exercise.Command { TheAction = Exercise.Command.Action.Withdraw, Amount = 75 };
        var account = new Account();
        account.Process(depositCommand);
        Console.WriteLine(account);
        account.Process(withdrawCommand);
        Console.WriteLine(account);
    }
}
