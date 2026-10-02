using ChainOfResponsabilityPattern.Handler;
using ChainOfResponsabilityPattern.Model;

namespace ChainOfResponsabilityPattern.ConcreteHandler
{
    public class ConcreteHandlerTwoEvent : HandlerCoREvent
    {
        public override void ProcessRequestHandler(object sender, ChainOfResponsabilityEventArgs chainOfResponsabilityEventArgs)
        {
            if (chainOfResponsabilityEventArgs?.ChainOfResponsabilityParam?.Name is nameof(ConcreteHandlerTwoEvent))
            {
                Console.WriteLine("Processing request in {0}", chainOfResponsabilityEventArgs?.ChainOfResponsabilityParam?.Name);
            }
            else
            {
                if (NextHanlder is null)
                {
                    Console.WriteLine("Chain finished");
                }
                else
                {
                    NextHanlder?.ProcessRequestHandler(this, chainOfResponsabilityEventArgs);
                }
            }
        }
    }
}
