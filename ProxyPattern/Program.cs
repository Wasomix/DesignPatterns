using ProxyPattern.Subject;

namespace ProxyPattern;

static class Program
{
    static void Main(string[] args)
    {
        var client = new Proxy(new RealSubject());
        client.Operation();
    }
}