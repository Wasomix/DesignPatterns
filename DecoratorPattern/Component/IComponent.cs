namespace DecoratorPattern.Component
{
    public interface IComponent
    {
        int Counter { get; set; }
        void Operation();
    }
}
