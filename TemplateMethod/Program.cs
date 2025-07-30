// See https://aka.ms/new-console-template for more information
using TemplateMethod.ConcreteClases;
using TemplateMethod.Template;

namespace TemplateMethod;

class Program
{
    static void Main(string[] args)
    {
        AbstractClass abstractClass = new ConcreteClassA();
        abstractClass.TemplateMethod();

        abstractClass = new ConcreteClassB();
        abstractClass.TemplateMethod();

        abstractClass = new ConcreteClassC();
        abstractClass.TemplateMethod();
    }
}
