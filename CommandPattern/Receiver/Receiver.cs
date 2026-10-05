namespace CommandPattern.Receiver
{
    public class Receiver : IReceiver
    {
        public void Action()
        {
            Console.WriteLine("Action from Receiver");
        }
    }
}
