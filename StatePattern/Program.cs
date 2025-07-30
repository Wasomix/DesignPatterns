// See https://aka.ms/new-console-template for more information
using StatePattern.States;

namespace StatePattern;
class Program
{
    static void Main(string[] args)
    {
        // The client code.
        var context = new Context(new StateA(number: 1));

        for (int i = 0; i < 10; i++)
        {
            context.Method1("method 1");
            context.Method2("method 2");
        }
    }
}
