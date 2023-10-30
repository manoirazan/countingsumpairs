
namespace CountingSumPairs
{
    class Pogram
    {
        public static void CountPairsWithSum(int[] arrayOfNumbers, int X)
        {
            int count = 0; 

            for (int i = 0; i < arrayOfNumbers.Length; i++)
                for (int j = i + 1; j < arrayOfNumbers.Length; j++)
                    if ((arrayOfNumbers[i] + arrayOfNumbers[j]) == X)
                        count++;

            Console.WriteLine($"X:{X}");
            Console.WriteLine($"Array:{String.Join(",",arrayOfNumbers)}");
            Console.WriteLine($"Output:{count}");
        }

        static public void Main()
        {
            int[] arrayOfNumbers = { 3, 4, 5, 6};
            int x = 1;           
            CountPairsWithSum(arrayOfNumbers, x);

            int[] arrayOfNumberTwo = { 0, 15, 32, 2000,15000 };
            int xx = 15;
            CountPairsWithSum(arrayOfNumberTwo, xx);


            int[] arrayOfNumbersThree = { 1, 1, 10, 32, 41 };
            int xxx = 42;
            CountPairsWithSum(arrayOfNumbersThree, xxx);

        }
    }
}

