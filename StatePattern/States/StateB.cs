namespace StatePattern.States;

internal class StateB : IState
{
    private readonly int _number;
    public StateB(int number) 
    {
        _number = number;
    }

    /// <summary>
    /// If we call this method, we stay in current state
    /// </summary>
    public void Method1(Context context)
    {
        Console.WriteLine($"We remain in State B for {context.Value} with number {_number}");
    }

    /// <summary>
    /// If we call this method, we transition into next state
    /// </summary>
    public void Method2(Context context)
    {
        context.SetState(new StateC(number : 3));

        Console.WriteLine($"We transition into State C for {context.Value}");
    }
}
