using MediatorPattern.Component;

namespace MediatorPattern.Mediator
{
    public class ConcreteMediator : IMediator
    {
        private readonly ComponentOne _componentOne;
        private readonly ComponentTwo _componentTwo;

        public ConcreteMediator(
            ComponentOne componentOne,
            ComponentTwo componentTwo
        ) 
        { 
            _componentOne = componentOne;
            _componentOne.SetMediator(this);
            _componentTwo = componentTwo;
            _componentTwo.SetMediator(this);
        }

        public void Notify(string message)
        {
            if (message.Contains(nameof(ComponentOne)))
            {
                _componentTwo.Receive("ComponentTwo receives message " + message);
            }

            if (message.Contains(nameof(ComponentTwo))) 
            {
                _componentOne.Receive("ComponentOne receives message " + message);
            }
        }
    }
}
