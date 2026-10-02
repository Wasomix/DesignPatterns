using ChainOfResponsabilityPattern.Model;

namespace ChainOfResponsabilityPattern.Handler
{
    public abstract class HandlerCoREvent
    {
        private readonly EventHandler<ChainOfResponsabilityEventArgs> _eventHandler;
        protected HandlerCoREvent? NextHanlder { get; set; } = null;

        public abstract void ProcessRequestHandler(object sender, ChainOfResponsabilityEventArgs chainOfResponsabilityEventArgs);

        protected HandlerCoREvent()
        {
            _eventHandler += ProcessRequestHandler;
        }

        public void SetNextHandler(HandlerCoREvent nextHanlder)
        {
            NextHanlder = nextHanlder;
        }

        public void ProcessRequest(ChainOfResponsabilityParam chainOfResponsabilityParam)
        {
            OnEvent(new ChainOfResponsabilityEventArgs { ChainOfResponsabilityParam = chainOfResponsabilityParam });
        }

        public virtual void OnEvent(ChainOfResponsabilityEventArgs chainOfResponsabilityEventArgs)
        {
            _eventHandler?.Invoke(this, chainOfResponsabilityEventArgs);
        }
    }
}
