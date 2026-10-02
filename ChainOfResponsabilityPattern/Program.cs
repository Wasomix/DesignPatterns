using ChainOfResponsabilityPattern.ConcreteHandler;
using ChainOfResponsabilityPattern.Handler;
using ChainOfResponsabilityPattern.Model;

namespace ChainOfResponsabilityPattern;

static class Program
{
    static void Main(string[] args)
    {
        TestExercise();

        Console.WriteLine("If you want to run example with events, type E; otherwise press enter");
        var keyPreseed = Console.ReadKey();
        Console.WriteLine();

        if(keyPreseed.KeyChar == 'E')
        {
            ExampleWithEvents();
        }
        else
        {
            ExampleWithoutEvents();
        }

    }

    private static void TestExercise()
    {
        //var game = new Game();
        //var goblin = new Goblin(game);
        //game.Creatures.Add(goblin);

        //var goblinKing = new GoblinKing(game);
        //game.Creatures.Add(goblinKing);

        //var goblin2 = new Goblin(game);
        //game.Creatures.Add(goblin2);
        ManyGoblinsTest();
    }

    public static void ManyGoblinsTest()
    {
        var game = new Game();
        var goblin = new Goblin(game);
        game.Creatures.Add(goblin);

        Assert.AreEqual(goblin.Attack, 1);
        Assert.AreEqual(goblin.Defense, 1);

        var goblin2 = new Goblin(game);
        game.Creatures.Add(goblin2);

        Assert.AreEqual(goblin.Attack, 1);
        Assert.AreEqual(goblin.Defense, 2);

        var goblin3 = new GoblinKing(game);
        game.Creatures.Add(goblin3);

        Assert.AreEqual(goblin.Attack, 2);
        Assert.AreEqual(goblin.Defense, 3);
    }

    private static void ExampleWithoutEvents()
    {
        HandlerCoR handlerCoROne = new ConcreteHandlerOne();
        HandlerCoR handlerCoRTwo = new ConcreteHandlerTwo();
        HandlerCoR handlerCoRThree = new ConcreteHandlerThree();

        handlerCoROne.SetNextHandler(handlerCoRTwo);
        handlerCoRTwo.SetNextHandler(handlerCoRThree);

        var param = new ChainOfResponsabilityParam { Name = nameof(ConcreteHandlerThree) };
        handlerCoROne.ProcessRequest(param);

        param.Name = nameof(ConcreteHandlerOne);
        handlerCoROne.ProcessRequest(param);
    }

    private static void ExampleWithEvents()
    {
        HandlerCoREvent handlerCoROne = new ConcreteHandlerOneEvent();
        HandlerCoREvent handlerCoRTwo = new ConcreteHandlerTwoEvent();
        HandlerCoREvent handlerCoRThree = new ConcreteHandlerThreeEvent();

        handlerCoROne.SetNextHandler(handlerCoRTwo);
        handlerCoRTwo.SetNextHandler(handlerCoRThree);

        var param = new ChainOfResponsabilityParam { Name = nameof(ConcreteHandlerThreeEvent) };
        handlerCoROne.ProcessRequest(param);

        param.Name = nameof(ConcreteHandlerOneEvent);
        handlerCoROne.ProcessRequest(param);
    }
}

public static class Assert
{
    public static bool AreEqual(int expectedValue, int calculatedValue)
    {
        return expectedValue == calculatedValue;
    }
}
