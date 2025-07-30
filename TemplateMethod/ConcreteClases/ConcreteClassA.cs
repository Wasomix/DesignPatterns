using TemplateMethod.Template;

namespace TemplateMethod.ConcreteClases
{
    public class ConcreteClassA : AbstractClass
    {
        protected override void Setup()
        {
            Console.WriteLine("Setup ConcreteClassA");
        }
        protected override void Operation1()
        {
            Console.WriteLine("Operation1 ConcreteClassA");
        }
        protected override void Operation2()
        {
            Console.WriteLine("Operation2 ConcreteClassA");
        }
        protected override void TearDown()
        {
            Console.WriteLine("TearDown ConcreteClassA");
        }
    }
}
