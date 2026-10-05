namespace CommandPattern.Exercise
{
    public class Command
    {
        public enum Action
        {
            Deposit,
            Withdraw
        }

        public Action TheAction {get; set;}
        public int Amount {get; set;}
        public bool Success {get; set;}
    }

    public class Account
    {
        public int Balance { get; set; }

        public void Process(Command c)
        {
            switch (c.TheAction) 
            { 
                case Command.Action.Deposit:
                    c.Success = Deposit(c.Amount);
                    break;
                case Command.Action.Withdraw:
                    c.Success = Withdraw(c.Amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
                    break;
            }
        }

        private bool Withdraw(int amount)
        {
            if(Balance - amount > 0)
            {
                Balance -= amount;
                return true;
            }

            return false;
        }

        private bool Deposit(int amount)
        {
            Balance += amount;
            return true;
        }

        public override string ToString() => $"Current balance: {Balance}";
    }
}
