namespace Facade
{
    public class MagicConstant
    {
        public int CalculateMagicConstant(int size)
        {
            return size * (size * size + 1) >> 1;
        }
    }

    public class Generator
    {
        private static readonly Random random = new Random();

        public List<int> Generate(int count)
        {
            return Enumerable.Range(0, count)
                .Select(_ => random.Next(1, 10))
                .ToList();
        }
    }

    public class Splitter
    {
        public List<List<int>> Split(List<List<int>> array)
        {
            var result = new List<List<int>>();

            var rowCount = array.Count;
            var colCount = array[0].Count;

            // get the rows
            for (int r = 0; r < rowCount; ++r)
            {
                var theRow = new List<int>();
                for (int c = 0; c < colCount; ++c)
                    theRow.Add(array[r][c]);
                result.Add(theRow);
            }

            // get the columns
            for (int c = 0; c < colCount; ++c)
            {
                var theCol = new List<int>();
                for (int r = 0; r < rowCount; ++r)
                    theCol.Add(array[r][c]);
                result.Add(theCol);
            }

            // now the diagonals
            var diag1 = new List<int>();
            var diag2 = new List<int>();
            for (int c = 0; c < colCount; ++c)
            {
                for (int r = 0; r < rowCount; ++r)
                {
                    if (c == r)
                        diag1.Add(array[r][c]);
                    var r2 = rowCount - r - 1;
                    if (c == r2)
                        diag2.Add(array[r][c]);
                }
            }

            result.Add(diag1);
            result.Add(diag2);

            return result;
        }
    }

    public class Verifier
    {
        public bool Verify(List<List<int>> array)
        {
            if (!array.Any()) return false;

            var expected = array.First().Sum();

            return array.All(t => t.Sum() == expected);
        }
    }

    public class MagicSquareGenerator
    {
        private readonly Generator _generator;
        private readonly MagicConstant _constant;
        private readonly Splitter _splitter;
        private readonly Verifier _verifier;

        public MagicSquareGenerator()
        {
            _generator = new Generator();
            _constant = new MagicConstant();
            _splitter = new Splitter();
            _verifier = new Verifier();
        }

        public List<List<int>> Generate(int size)
        {
            var magicConstant = _constant.CalculateMagicConstant(size);
            var dataMatrix = new List<List<int>>();
            var verify = false;
            int numberOfIterations = 0;

            do
            {
                Console.WriteLine("Iteration {0}", numberOfIterations++);
                dataMatrix.Clear();

                for (int i = 0; i < size; ++i)
                {
                    int rowSum = 0;
                    List<int> row;
                    do
                    {
                        row = _generator.Generate(size);
                        rowSum = row.Sum();
                    } while (rowSum != magicConstant);
                    dataMatrix.Add(row);
                }

                var split = _splitter.Split(dataMatrix);
                verify = _verifier.Verify(split);
            } while (!verify);


            return dataMatrix;
        }
    }
}
