using ChainOfResponsabilityPattern.Model;

namespace ChainOfResponsabilityPattern.Handler
{
    public abstract class HandlerCoR
    {
        protected HandlerCoR? NextHanlder { get; set; } = null;

        public void SetNextHandler(HandlerCoR nextHanlder)
        {
            NextHanlder = nextHanlder;
        }

        public abstract void ProcessRequest(ChainOfResponsabilityParam chainOfResponsabilityParam);
    }
}
