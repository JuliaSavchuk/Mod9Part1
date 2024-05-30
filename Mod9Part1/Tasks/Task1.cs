namespace Mod9Part1
{
    public delegate IEnumerable<int> ArrayOperation(int[] array);

    internal class ArrayProcessor
    {
        public IEnumerable<int> GetEvenNumbers(int[] array)
        {
            return array.Where(x => x % 2 == 0);
        }

        public IEnumerable<int> GetOddNumbers(int[] array)
        {
            return array.Where(x => x % 2 != 0);
        }

        public IEnumerable<int> GetPrimeNumbers(int[] array)
        {
            return array.Where(IsPrime);
        }

        public IEnumerable<int> GetFibonacciNumbers(int[] array)
        {
            var fibonacciSet = new HashSet<int>(GenerateFibonacci(array.Max()));
            return array.Where(x => fibonacciSet.Contains(x));
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private IEnumerable<int> GenerateFibonacci(int max)
        {
            int a = 0, b = 1;
            while (a <= max)
            {
                yield return a;
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}
