using TemplateMethod.Template;

namespace TemplateMethod.ConcreteClases
{
    public class ConcreteClassB : AbstractClass
    {
        protected override void Setup()
        {
            Console.WriteLine("Setup ConcreteClassB");
        }
        protected override void Operation1()
        {
            Console.WriteLine("Operation1 ConcreteClassB");
        }
        protected override void Operation2()
        {
            Console.WriteLine("Operation2 ConcreteClassB");
        }
        protected override void TearDown()
        {
            Console.WriteLine("TearDown ConcreteClassB");
        }
    }
}
