using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregate
{
    public class ConcreteAggregateA : IAggregate
    {
        private List<object> _items = [];

        public IIterator CreateIterator()
        {
            return new ConcreteIteratorA(this);
        }

        public int Count { get { return _items.Count; } }
        
        public void Append(object item) => _items.Add(item);

        public void Remove(object item) => _items.Remove(item);

        public object this[int index] 
        { 
            get
            {
                return _items[index];
            }
            set
            {
                _items.Add(value);
            }
        }
    }
}
