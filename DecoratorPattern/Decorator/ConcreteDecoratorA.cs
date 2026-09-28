using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    internal class ConcreteDecoratorA : BaseDecorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component)
        {
        }

        public override int Counter { 
            get => _component.Counter++; 
            set => _component.Counter = value; 
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Operation ConcreteDecoratorA counter value: " + _component.Counter);
        }
    }
}
