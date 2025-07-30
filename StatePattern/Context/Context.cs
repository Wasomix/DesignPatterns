using StatePattern.States;

namespace StatePattern;

public class Context
{
    private IState _state;
    private string _value;

    public string Value
    {
        get { return _value; }
    }

    public Context(IState state)
    {
        _state = state;
        _value = string.Empty;
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public void Method1(string value)
    {
        _value = value;
        _state.Method1(this);
    }

    public void Method2(string value) 
    {
        _value = value;
        _state.Method2(this);
    }
}
