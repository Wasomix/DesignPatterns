using FactoryPattern.Product;

namespace FactoryPattern.Creator
{
    public class ConcretePersonFactory : IPersonFactory
    {
        private static int _personId = 0;
        public IPerson CreatePerson(string personName)
        {
            return new ConcretePerson(_personId++, personName);
        }
    }
}
