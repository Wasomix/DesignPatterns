using MediatorPattern.Component;
using MediatorPattern.Mediator;

namespace MediatorPattern;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("If you want to run example exercise, type E; otherwise press enter");
        var keyPreseed = Console.ReadKey();
        Console.WriteLine();

        if (keyPreseed.KeyChar == 'E')
        {
            RunExercise();
        }
        else
        {
            RunExample();
        }
    }

    private static void RunExample()
    {
        var compOne = new ComponentOne();
        var compTwo = new ComponentTwo();
        _ = new ConcreteMediator(compOne, compTwo);

        compOne.MethodOne();
        compTwo.MethodOne();
    }

    private static void RunExercise()
    {
        var mediator = new Exercise.Mediator();

        var john = new Exercise.Participant(mediator);
        var jane = new Exercise.Participant(mediator);
        var mike = new Exercise.Participant(mediator);
        var abby = new Exercise.Participant(mediator);

        var participants = new List<Exercise.Participant>
        {
            john, jane, mike, abby
        };

        
        john.Say(2); // John=0; Jane=2; Mike=2; Abby=2
        PrintParticipants(participants);

        abby.Say(5); // John=5; Jane=7; Mike=7; Abby=2
        PrintParticipants(participants);

        mike.Say(1); // John=6; Jane=8; Mike=7; Abby=3
        PrintParticipants(participants);
    }


    private static void PrintParticipants(List<Exercise.Participant> participants)
    {
        foreach (Exercise.Participant participant in participants) 
        {
            Console.WriteLine(participant);
        }
    }
}
