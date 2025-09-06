using IteratorPattern.Aggregate;

namespace IteratorPattern.Iterator
{
    public class ConcreteIteratorA : IIterator
    {
        private readonly ConcreteAggregateA _concreteAggregateA;
        private int _counter;
        public ConcreteIteratorA(ConcreteAggregateA concreteAggregateA) 
        {
            _concreteAggregateA = concreteAggregateA;
            _counter = 0;
        }

        public object First()
        {
            return _concreteAggregateA[0];
        }

        public object? Next()
        {
            ++_counter;

            if (IsDone()) 
            {
                return null;
            }

            return _concreteAggregateA[_counter];
        }

        public object CurrentItem()
        {
            return _concreteAggregateA[_counter];
        }

        public bool IsDone()
        {
            return _counter >= _concreteAggregateA.Count;
        }
    }
}
