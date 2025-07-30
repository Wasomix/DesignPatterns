using TemplateMethod.Template;

namespace TemplateMethod.ConcreteClases
{
    public class ConcreteClassC : AbstractClass
    {
        protected override void Setup()
        {
            Console.WriteLine("Setup ConcreteClassC");
        }
        protected override void Operation1()
        {
            Console.WriteLine("Operation1 ConcreteClassC");
        }
        protected override void Operation2()
        {
            Console.WriteLine("Operation2 ConcreteClassC");
        }
        protected override void TearDown()
        {
            Console.WriteLine("TearDown ConcreteClassC");
        }
    }
}
