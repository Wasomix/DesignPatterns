using Facade.Facade;
using Facade.Subsystem;

namespace Facade;
static class Program
{
    static void Main(string[] args)
    {
        var facadeOne = new FacadeOne(new ClassA(), new ClassC());
        facadeOne.OperationFacadeOne();
        var facadeTwo = new FacadeTwo(new ClassB());
        facadeTwo.OperationFacadeTwo();
    }
}