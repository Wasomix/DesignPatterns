using ProxyPattern.Subject;

namespace ProxyPattern
{
    public class Proxy : ISubject
    {
        private readonly RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public void Operation()
        {
            Console.WriteLine("Operation from Proxy calling");
            _realSubject.Operation();
        }
    }
}
