using FactoryPattern.Creator;
using FactoryPattern.Product;

namespace FactoryPattern;

static class Program
{
    static void Main(string[] args)
    {
        var persons = new List<IPerson>();
        var personsFactory = new ConcretePersonFactory();
        persons.Add(personsFactory.CreatePerson("Bob"));
        persons.Add(personsFactory.CreatePerson("Jane"));
        persons.Add(personsFactory.CreatePerson("Jhon"));
        persons.Add(personsFactory.CreatePerson("May"));
        persons.Add(personsFactory.CreatePerson("Mike"));

        foreach (var person in persons)
        {
            Console.WriteLine(person);
        }        
    }
}
