using MediatorPattern.Mediator;

namespace MediatorPattern.Component
{
    public class BaseComponent
    {
        protected IMediator? _mediator;

        public void SetMediator(IMediator mediator) => _mediator = mediator;
    }
}
