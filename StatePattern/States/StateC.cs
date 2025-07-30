namespace StatePattern.States;

internal class StateC : IState
{
    private readonly int _number;

    public StateC(int number) 
    { 
        _number = number;
    }

    /// <summary>
    /// If we call this method, we stay in current state
    /// </summary>
    public void Method1(Context context)
    {
        Console.WriteLine($"We remain in State C for {context.Value} with number {_number}");
    }

    /// <summary>
    /// If we call this method, we transition into next state
    /// </summary>
    public void Method2(Context context) 
    {
        context.SetState(new StateA(number: 1));

        Console.WriteLine($"We transition into State A for {context.Value}");
    }
}
