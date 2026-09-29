using Facade.Subsystem;

namespace Facade.Facade
{
    public class FacadeOne: IFacadeOne
    {
        private readonly IClassA _classA;
        private readonly IClassC _classC;

        public FacadeOne(
            IClassA classA,
            IClassC classC    
        )
        {
            _classA = classA;
            _classC = classC;
        }

        public void OperationFacadeOne()
        {
            Console.WriteLine("Start FacadeOne");
            _classA.MethodOne();
            _classA.MethodThree();
            _classC.MethodTwo();
            _classC.MethodThree();
            Console.WriteLine("End FacadeOne");
        }
    }
}
