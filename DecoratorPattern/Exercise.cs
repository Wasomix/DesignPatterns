namespace DecoratorPattern.Exercise
{
    public class Exercise
    {
        public void Run()
        {
            //var component =  new ConcreteComponent(age: 10);
            //var lizard = new Lizard(component);
            //var bird = new Bird(lizard);
            //var dragon = new Dragon(bird);
            var dragon = new Dragon(new Bird(new Lizard(new ConcreteComponent(age: 10))));
            Console.WriteLine(dragon.Operation());
        }
    }

#if true //Decorator
    public interface IComponent
    {
        public /*abstract*/ int Age { get; set; }
        public /*abstract*/ string Operation();
    }

    public class ConcreteComponent : IComponent
    {
        public ConcreteComponent(int age)
        {
            Age = age;
        }

        public /*override*/ int Age { get; set; }

        public /*override*/ string Operation()
        {
            return "ConcreteComponent ";
        }
    }

    public abstract class BaseDecorator : IComponent
    {
        protected readonly IComponent _component;
        public virtual int Age { get; set; }

        protected BaseDecorator(IComponent component)
        {
            _component = component;
        }
        public virtual string Operation()
        {
            return _component.Operation();
        }
    }

    public class Bird : BaseDecorator
    {
        public Bird(IComponent component) : base(component)
        {
        }

        public override int Age
        {
            get => _component.Age;
            set => _component.Age = value;
        }

        public override string Operation()
        {
            return base.Operation() + Fly() + " ";
        }

        private string Fly()
        {
            return (_component.Age < 10) ? "flying" : "too old";
        }
    }

    public class Lizard : BaseDecorator
    {
        public Lizard(IComponent component) : base(component)
        {
        }

        public override int Age
        {
            get => _component.Age;
            set => _component.Age = value;
        }

        public override string Operation()
        {
            return base.Operation() + Crawl() + " ";
        }

        private string Crawl()
        {
            return (_component.Age > 1) ? "crawling" : "too young";
        }
    }

    // Concrete component
    public class Dragon : BaseDecorator
    {
        public Dragon(IComponent component) : base(component)
        {
        }

        public override int Age
        {
            get { return _component.Age; }
            set { _component.Age = value; }
        }

        public override string Operation()
        {
            return base.Operation() + "dragon";
        }
    }
#else // Composition

    public interface IComponent
    {
        public int Age { get; set; }
    }

    public class Bird : IComponent
    {
        public int Age { get; set; }

        public string Fly()
        {
            return (Age < 10) ? "flying" : "too old";
        }
    }

    public class Lizard : IComponent
    {
        public int Age { get; set; }

        public string Crawl()
        {
            return (Age > 1) ? "crawling" : "too young";
        }
    }

    public class Dragon // no need for interfaces
    {
        private readonly Bird _bird = new Bird();
        private readonly Lizard _lizard = new Lizard();

        public Dragon()
        {

        }

        public int Age
        {
            get { return _bird.Age; }
            set {  
                _bird.Age = value;
                _lizard.Age = value;
            }
        }

        public string Fly()
        {
            return _bird.Fly();
        }

        public string Crawl()
        {
            return _lizard.Crawl();
        }
    }
#endif
}
