using Facade.Subsystem;

namespace Facade.Facade
{
    public class FacadeTwo: IFacadeTwo
    {
        private readonly IClassB _classB;

        public FacadeTwo(IClassB classB)
        {
            _classB = classB;
        }

        public void OperationFacadeTwo()
        {
            Console.WriteLine("Start FacadeTwo");
            _classB.MethodOne();
            _classB.MethodTwo();
            _classB.MethodThree();
            Console.WriteLine("End FacadeTwo");
        }
    }
}
