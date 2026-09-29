namespace FlyweightPattern;

static class Program
{
    static void Main(string[] args)
    {
        var sentence = new Sentence("hello world");
        sentence[1].Capitalize = true;
        Console.WriteLine(sentence); // writes "hello

        sentence = new Sentence(" alpha beta gamma");
        sentence[1].Capitalize = true;
        Console.WriteLine(sentence); // writes "alpha beta gamma
    }
}
