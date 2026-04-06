using FactoryPattern.Creator;
using FactoryPattern.Product;

namespace FactoryPattern;

static class Program
{
    private static readonly IList<string> _personNames = new List<string>
    {
        "Bob",
        "Jane",
        "John",
        "May",
        "Mike"
    };

    static void Main(string[] args)
    {
        var persons = new List<IPerson>();
        var personsFactory = new ConcretePersonFactory();

        foreach(var personName in _personNames)
        {
            persons.Add(personsFactory.CreatePerson(personName));
        }
        
        foreach (var person in persons)
        {
            Console.WriteLine(person);
        }        
    }
}
