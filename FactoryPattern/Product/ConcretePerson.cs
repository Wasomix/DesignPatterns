namespace FactoryPattern.Product
{
    public class ConcretePerson : IPerson
    {
        public ConcretePerson(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}";
        }
    }
}
