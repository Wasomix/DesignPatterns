using FactoryPattern.Product;

namespace FactoryPattern.Creator
{
    public interface IPersonFactory
    {
        IPerson CreatePerson(string personName);
    }
}
