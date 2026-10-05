
using MediatorPattern.Mediator;

namespace MediatorPattern.Component
{
    public class ComponentTwo : BaseComponent
    {
        public void MethodOne()
        {
            _mediator?.Notify("MethodOne from ComponentTwo");
        }

        public void Receive(string message)
        {
            Console.WriteLine(message);
        }
    }
}
