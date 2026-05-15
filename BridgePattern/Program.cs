using BridgePattern.Renderer;
using BridgePattern.Shape;
using System;

namespace BridgePattern;

static class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Start of program");

        Console.WriteLine(new Triangle(new RasterRenderer()).ToString());
        Console.WriteLine(new Triangle(new VectorRenderer()).ToString());

        Console.WriteLine(new Square(new RasterRenderer()).ToString());
        Console.WriteLine(new Square(new VectorRenderer()).ToString());

        Console.WriteLine("End of program");
    }
}
