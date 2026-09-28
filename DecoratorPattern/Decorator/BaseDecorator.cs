using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public abstract class BaseDecorator : IComponent
    {
        protected readonly IComponent _component;

        protected BaseDecorator(IComponent component)
        {
            _component = component;
        }

        public virtual int Counter { 
            get => _component.Counter++; 
            set => _component.Counter = value; 
        }

        public virtual void Operation()
        {
            _component.Operation();
        }
    }
}
