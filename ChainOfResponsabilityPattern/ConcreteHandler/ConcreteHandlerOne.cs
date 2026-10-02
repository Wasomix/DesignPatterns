using ChainOfResponsabilityPattern.Handler;
using ChainOfResponsabilityPattern.Model;

namespace ChainOfResponsabilityPattern.ConcreteHandler
{
    public class ConcreteHandlerOne : HandlerCoR
    {
        public override void ProcessRequest(ChainOfResponsabilityParam chainOfResponsabilityParam)
        {
            if (chainOfResponsabilityParam.Name is nameof(ConcreteHandlerOne)) 
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
