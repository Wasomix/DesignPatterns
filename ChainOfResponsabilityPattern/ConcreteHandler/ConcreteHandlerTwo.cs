using ChainOfResponsabilityPattern.Handler;
using ChainOfResponsabilityPattern.Model;

namespace ChainOfResponsabilityPattern.ConcreteHandler
{
    public class ConcreteHandlerTwo : HandlerCoR
    {
        public override void ProcessRequest(ChainOfResponsabilityParam chainOfResponsabilityParam)
        {
            if (chainOfResponsabilityParam.Name is nameof(ConcreteHandlerTwo)) 
            { 
                Console.WriteLine("Processing request in {0}", chainOfResponsabilityParam.Name);
            }
            else
            {
                if(NextHanlder is null)
                {
                    Console.WriteLine("Chain finished");
                }
                else
                {
                    NextHanlder?.ProcessRequest(chainOfResponsabilityParam);
                }
            }
        }
    }
}
