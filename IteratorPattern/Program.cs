using IteratorPattern.Aggregate;
using IteratorPattern.Model;

namespace IteratorPattern;
class Program
{
    static void Main(string[] args)
    {
        // The client code.
        var aggregate = new ConcreteAggregateA();

        aggregate.Append(new Item { Name = "Name1", Surname = "Surname1" });
        aggregate.Append(new Item { Name = "Name2", Surname = "Surname2" });
        aggregate.Append(new Item { Name = "Name3", Surname = "Surname3" });
        aggregate.Append(new Item { Name = "Name4", Surname = "Surname4" });

        var iterator = aggregate.CreateIterator();

        var item = iterator.First() as Item;
        Console.WriteLine(item?.Name + " " + item?.Surname);

        while(!iterator.IsDone())
        {
            item = iterator.Next() as Item;
            Console.WriteLine(item?.Name + " " + item?.Surname);
        }
    }
}