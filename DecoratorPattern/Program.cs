using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern;
static class Program
{
    static void Main(string[] args)
    {
        var component = new ConcreteComponentA(counter: 3);
        var concreteDecoratorA = new ConcreteDecoratorA(component);
        var concreteDecoratorB = new ConcreteDecoratorB(concreteDecoratorA);
        concreteDecoratorB.Operation();
    }
}
