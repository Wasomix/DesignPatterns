namespace DecoratorPattern.Component
{
    internal class ConcreteComponentA : IComponent
    {
        private int _counter;
        public int Counter { 
            get => _counter++; 
            set => _counter = value; 
        }

        public ConcreteComponentA(int counter)
        {
            _counter = counter;
        }

        public void Operation()
        {
            Console.WriteLine("Operation ConcreteComponentA counter value: " + Counter);
        }
    }
}
