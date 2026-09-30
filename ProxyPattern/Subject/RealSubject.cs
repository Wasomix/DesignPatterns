namespace ProxyPattern.Subject
{
    public class RealSubject : ISubject
    {
        public void Operation()
        {
            Console.WriteLine("Operation from RealSubject");
        }
    }
}
