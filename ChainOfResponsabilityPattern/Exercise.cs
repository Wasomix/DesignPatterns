namespace ChainOfResponsabilityPattern
{
    //public abstract class Creature
    //{
    //    public int Attack { get; set; }
    //    public int Defense { get; set; }
    //    protected readonly Game _game;

    //    abstract void 
    //    protected Creature(Game game)

    //}

    //public class Goblin : Creature
    //{
    //    private readonly Game _game;
    //    public Goblin(Game game) 
    //    { 
    //        Attack = 1; 
    //        Defense = 1;
    //        _game = game;
    //    }
    //}

    //public class GoblinKing : Goblin
    //{
    //    public GoblinKing(Game game) : base(game) 
    //    {
    //        Attack = 3;
    //        Defense = 3;         
    //    }
    //}

    //public class Game
    //{
    //    public IList<Creature> Creatures;

    //    public Game()
    //    {
    //        Creatures = new List<Creature>();
    //    }
    //}

    //public static class CreaturesExtension
    //{
    //    public static void Add(this ICollection<Creature> list, Creature creature)
    //    {
    //        if(list.Count == 0)
    //        {
    //            list.Add(creature);
    //            return;
    //        }

    //        if(creature is Goblin)
    //        {
    //            for(int i=0; i<list.Count-1; i++)
    //            {
    //                var item = list.ElementAt(i);
    //                item.Defense++;
    //            }
    //        }

    //        if(creature is GoblinKing)
    //        {
    //            for (int i = 0; i < list.Count - 1; i++)
    //            {
    //                var item = list.ElementAt(i);
    //                item.Attack++;
    //                item.Defense++;
    //            }
    //        }

    //        list.Add(creature);
    //    }
    //}


    public abstract class Creature
    {
        protected Game game;
        protected readonly int baseAttack;
        protected readonly int baseDefense;

        protected Creature(Game game, int baseAttack, int baseDefense)
        {
            this.game = game;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
        }

        public virtual int Attack { get; set; }
        public virtual int Defense { get; set; }
        public abstract void ProcessRequest(object source, StatQuery statQuery);
    }

    public class Goblin : Creature
    {
        public override void ProcessRequest(object source, StatQuery statQuery)
        {
            if (ReferenceEquals(source, this))
            {
                switch (statQuery.Statistic)
                {
                    case Statistic.Attack:
                        statQuery.Result += baseAttack;
                        break;
                    case Statistic.Defense:
                        statQuery.Result += baseDefense;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                if (statQuery.Statistic == Statistic.Defense)
                {
                    statQuery.Result++;
                }
            }
        }

        public override int Defense
        {
            get
            {
                var q = new StatQuery { Statistic = Statistic.Defense };
                foreach (var c in game.Creatures)
                    c.ProcessRequest(this, q);
                return q.Result;
            }
        }

        public override int Attack
        {
            get
            {
                var q = new StatQuery { Statistic = Statistic.Attack };
                foreach (var c in game.Creatures)
                    c.ProcessRequest(this, q);
                return q.Result;
            }
        }

        public Goblin(Game game) : base(game, 1, 1)
        {
        }

        protected Goblin(Game game, int baseAttack, int baseDefense) : base(game,
          baseAttack, baseDefense)
        {
        }
    }

    public class GoblinKing : Goblin
    {
        public GoblinKing(Game game) : base(game, 3, 3)
        {
        }

        public override void ProcessRequest(object source, StatQuery statQuery)
        {
            if (!ReferenceEquals(source, this) && statQuery.Statistic == Statistic.Attack)
            {
                statQuery.Result++; // every goblin gets +1 attack
            }
            else base.ProcessRequest(source, statQuery);
        }
    }

    public enum Statistic
    {
        Attack,
        Defense
    }

    public class StatQuery
    {
        public Statistic Statistic;
        public int Result;
    }

    public class Game
    {
        public IList<Creature> Creatures = new List<Creature>();
    }
}
