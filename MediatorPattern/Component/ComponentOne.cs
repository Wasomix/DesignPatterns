namespace MediatorPattern.Component
{
    public class ComponentOne : BaseComponent
    {        
        public void MethodOne()
        {
            _mediator?.Notify("MethodOne from ComponentOne");
        }

        public void Receive(string message)
        {
            Console.WriteLine(message);
        }
    }
}
