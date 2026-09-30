namespace ProxyPattern
{
    public interface IPerson
    {
        int Age { get; set; }

        string Drink();
        string DrinkAndDrive();
        string Drive();
    }

    public class Person : IPerson
    {
        public int Age { get; set; }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }

    public class ResponsiblePerson : IPerson
    {
        private readonly Person _person;
        public ResponsiblePerson(Person person)
        {
            _person = person;
        }

        public int Age {
            get => _person.Age;
            set => _person.Age = value;
        }

        public string Drink()
        {
            if(_person.Age < 18)
            {
                return "too young";
            }

            return _person.Drink();
        }

        public string Drive()
        {
            if(_person.Age < 16)
            {
                return "too young";
            }

            return _person.Drive();
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}
