namespace MediatorPattern.Exercise
{
    public class Participant
    {
        private int _value;

        public int Value => _value;

        private readonly IMediator _mediator;

        public Participant(Mediator mediator)
        {
            _mediator = mediator;
            _mediator.Register(this);
            _value = 0;
        }

        public void Say(int n)
        {
            _mediator.Notify(this, n);
        }

        public void Receive(int value)
        {
            _value += value;
        }

        public override string ToString()
        {
            return $"Participant {GetHashCode()} has value = {Value}";
        }
    }

    public interface IMediator
    {
        void Notify(Participant participant, int value);

        void Register(Participant participant);
    }

    public class Mediator : IMediator
    {
        private readonly List<Participant> _participants;

        public Mediator() => _participants = new List<Participant>();

        public void Notify(Participant participant, int value)
        {
            foreach (var p in _participants.Where(p => participant != p))
            {
                p.Receive(value);
            }
        }

        public void Register(Participant participant)
        {
            _participants.Add(participant);
        }
    }
}
