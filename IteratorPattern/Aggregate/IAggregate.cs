using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregate
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
