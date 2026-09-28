using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    internal class ConcreteDecoratorB : BaseDecorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }

        public override int Counter { 
            get => _component.Counter++; 
            set => _component.Counter = value; 
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Operation ConcreteDecoratorB counter value: " + _component.Counter);
        }
    }
}
